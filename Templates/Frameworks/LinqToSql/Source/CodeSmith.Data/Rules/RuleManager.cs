﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Linq;
using CodeSmith.Data.Attributes;
using CodeSmith.Data.Rules.Validation;

namespace CodeSmith.Data.Rules
{
    /// <summary>
    /// A class to manage rules.
    /// </summary>
    public class RuleManager
    {
        private static RuleCollection _sharedBusinessRules;
        private RuleCollection _businessRules;

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleManager"/> class.
        /// </summary>
        public RuleManager()
        {
            BrokenRules = new BrokenRuleCollection();
        }

        /// <summary>
        /// Gets the broken rules.
        /// </summary>
        /// <value>The broken rules.</value>
        public BrokenRuleCollection BrokenRules { get; private set; }

        /// <summary>
        /// Adds the specified rule.
        /// </summary>
        /// <typeparam name="EntityType">The type of the entity.</typeparam>
        /// <param name="rule">The rule.</param>
        public void Add<EntityType>(IRule rule)
        {
            if (_businessRules == null)
                _businessRules = new RuleCollection();

            if (_businessRules.ContainsKey(typeof (EntityType)))
                _businessRules[typeof (EntityType)].Add(rule);
            else
                _businessRules.Add(typeof (EntityType), new List<IRule> {rule});
        }

        /// <summary>
        /// Adds the shared global rules.
        /// </summary>
        /// <typeparam name="EntityType">The type of the entity.</typeparam>
        /// <param name="rule">The rule.</param>
        public static void AddShared<EntityType>(IRule rule)
        {
            if (_sharedBusinessRules == null)
                _sharedBusinessRules = new RuleCollection();

            if (_sharedBusinessRules.ContainsKey(typeof (EntityType)))
                _sharedBusinessRules[typeof (EntityType)].Add(rule);
            else
                _sharedBusinessRules.Add(typeof (EntityType), new List<IRule> {rule});
        }

        /// <summary>
        /// Adds rules to the rule manager from any property attributes on the specified type. 
        /// </summary>
        /// <typeparam name="EntityType">The type of the entity.</typeparam>
        public static void AddShared<EntityType>()
        {
            Type entityType = typeof (EntityType);
            Type metadata = null;

            var metadataTypeAttribute = entityType.GetCustomAttributes(typeof (MetadataTypeAttribute), true).FirstOrDefault() as MetadataTypeAttribute;
            if (metadataTypeAttribute != null)
                metadata = metadataTypeAttribute.MetadataClassType;

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            PropertyDescriptorCollection metadataProperties = null;
            if (metadata != null)
                metadataProperties = TypeDescriptor.GetProperties(metadata);

            foreach (PropertyDescriptor property in properties)
            {
                IList<Attribute> attributes = GetAttributes(property, metadataProperties);

                foreach (Attribute attribute in attributes)
                    if (attribute is RuleAttributeBase)
                    {
                        var ruleAttribute = (RuleAttributeBase) attribute;
                        AddShared<EntityType>(ruleAttribute.CreateRule(property.Name));
                    }
                    else if (attribute is ValidationAttribute)
                        AddValidation<EntityType>(property.Name, attribute);
            }
        }

        private static void AddValidation<EntityType>(string property, Attribute attribute)
        {
            if (attribute is StringLengthAttribute)
            {
                var validationAttribute = (StringLengthAttribute) attribute;
                if (string.IsNullOrEmpty(validationAttribute.ErrorMessage))
                    AddShared<EntityType>(new LengthRule(property, validationAttribute.MaximumLength));
                else
                    AddShared<EntityType>(new LengthRule(property, validationAttribute.ErrorMessage, validationAttribute.MaximumLength));
            }
            else if (attribute is RequiredAttribute)
            {
                var validationAttribute = (RequiredAttribute) attribute;
                if (string.IsNullOrEmpty(validationAttribute.ErrorMessage))
                    AddShared<EntityType>(new RequiredRule(property));
                else
                    AddShared<EntityType>(new RequiredRule(property, validationAttribute.ErrorMessage));
            }
            else if (attribute is RegularExpressionAttribute)
            {
                var validationAttribute = (RegularExpressionAttribute) attribute;
                if (string.IsNullOrEmpty(validationAttribute.ErrorMessage))
                    AddShared<EntityType>(new RegexRule(property, validationAttribute.Pattern));
                else
                    AddShared<EntityType>(new RegexRule(property, validationAttribute.ErrorMessage, validationAttribute.Pattern));
            }
            else if (attribute is RangeAttribute)
            {
                var validationAttribute = (RangeAttribute) attribute;
                if (string.IsNullOrEmpty(validationAttribute.ErrorMessage))
                {
                    var rangeRule = Activator.CreateInstance(typeof (RangeRule<>).MakeGenericType(validationAttribute.OperandType),
                                                             property, validationAttribute.Minimum, validationAttribute.Maximum) as PropertyRuleBase;
                    AddShared<EntityType>(rangeRule);
                }

                else
                {
                    var rangeRule = Activator.CreateInstance(typeof (RangeRule<>).MakeGenericType(validationAttribute.OperandType),
                                                             property, validationAttribute.ErrorMessage,
                                                             validationAttribute.Minimum, validationAttribute.Maximum) as PropertyRuleBase;
                    AddShared<EntityType>(rangeRule);
                }
            }
        }

        private static IList<Attribute> GetAttributes(MemberDescriptor property, PropertyDescriptorCollection metadataProperties)
        {
            // 1) only looking for ValidationAttribute attributes
            // 2) only one rule per attribute type can exist, last in wins.

            var attributes = new Dictionary<Type, Attribute>();
            foreach (Attribute attribute in property.Attributes)
                if (attribute is ValidationAttribute)
                    attributes[attribute.GetType()] = attribute;

            if (metadataProperties == null)
                return attributes.Values.ToList();

            PropertyDescriptor metadataProperty = metadataProperties.Find(property.Name, false);
            if (metadataProperty == null)
                return attributes.Values.ToList();

            foreach (Attribute attribute in metadataProperty.Attributes)
                if (attribute is ValidationAttribute)
                    attributes[attribute.GetType()] = attribute; // overwrite previous type

            return attributes.Values.ToList();
        }

        /// <summary>
        /// Gets the rules for a type.
        /// </summary>
        /// <typeparam name="EntityType">The type of the entity.</typeparam>
        /// <returns>A collection of rules.</returns>
        public List<IRule> GetRules<EntityType>()
        {
            return GetRules(typeof (EntityType));
        }

        /// <summary>
        /// Gets the rules for a type.
        /// </summary>
        /// <param name="type">The type of the entity.</param>
        /// <returns>A collection of rules.</returns>
        public List<IRule> GetRules(Type type)
        {
            var rules = new List<IRule>();

            if (_sharedBusinessRules != null && _sharedBusinessRules.ContainsKey(type))
                rules.AddRange(_sharedBusinessRules[type]);
            if (_businessRules != null && _businessRules.ContainsKey(type))
                rules.AddRange(_businessRules[type]);

            return rules;
        }

        /// <summary>
        /// Run the rules specified objects.
        /// </summary>
        /// <param name="objects">The objects to run rules on.</param>
        /// <returns><c>true</c> if rules ran successfully; otherwise, <c>false</c>.</returns>
        public bool Run(List<TrackedObject> objects)
        {
            BrokenRules.Clear();
            bool isSuccess = true;

            foreach (TrackedObject o in objects)
            {
                List<IRule> rules = GetRules(o.Current.GetType());
                rules.Sort(
                    delegate(IRule x, IRule y)
                    {
                        if (x == null && y == null)
                            return 0;
                        else if (x == null)
                            return -1;
                        else if (y == null)
                            return 1;
                        else
                            return x.Priority.CompareTo(y.Priority);
                    }
                    );

                foreach (IRule rule in rules)
                {
                    var context = new RuleContext(o, rule);
                    rule.Run(context);
                    isSuccess &= context.Success;
                    if (!context.Success)
                        BrokenRules.Add(new BrokenRule(context));
                }
            }

            return isSuccess;
        }

        /// <summary>
        /// Run the rules specified objects.
        /// </summary>
        /// <param name="objects">The objects to run rules on.</param>
        /// <returns><c>true</c> if rules ran successfully; otherwise, <c>false</c>.</returns>
        public bool Run(params object[] objects)
        {
            var tracked = new List<TrackedObject>();
            foreach (object o in objects)
                tracked.Add(new TrackedObject {Current = o});

            return Run(tracked);
        }

        /// <summary>
        /// Run the rules specified changed objects.
        /// </summary>
        /// <param name="changedObjects">The changed objects.</param>
        /// <returns><c>true</c> if rules ran successfully; otherwise, <c>false</c>.</returns>
        public bool Run(ChangeSet changedObjects)
        {
            var tracked = new List<TrackedObject>();

            foreach (object o in changedObjects.Inserts)
                tracked.Add(new TrackedObject {Current = o, IsNew = true});
            foreach (object o in changedObjects.Updates)
                tracked.Add(new TrackedObject {Current = o, IsChanged = true});
            foreach (object o in changedObjects.Deletes)
                tracked.Add(new TrackedObject {Current = o, IsDeleted = true});

            return Run(tracked);
        }
    }
}