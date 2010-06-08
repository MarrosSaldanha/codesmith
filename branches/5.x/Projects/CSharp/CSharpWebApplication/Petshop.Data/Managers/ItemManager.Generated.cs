
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using CodeSmith.Data;
using CodeSmith.Data.Rules;
using CodeSmith.Data.Rules.Assign;
using CodeSmith.Data.Rules.Validation;

namespace Petshop.Data
{
    /// <summary>
    /// The manager class for Item.
    /// </summary>
    public partial class ItemManager : EntityManagerBase<PetshopDataManager, Item>
    {
        /// <summary>
        /// Initializes the <see cref="ItemManager"/> class.
        /// </summary>
        static ItemManager()
        {
            RuleManager.AddShared<Item>(typeof(PetshopDataContext));
            AddRules();
        }

        /// <summary>
        /// Initializes the <see cref="ItemManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        public ItemManager(PetshopDataManager manager) : base(manager)
        {
            OnCreated();
        }

        /// <summary>
        /// Gets the current context.
        /// </summary>
        protected PetshopDataContext Context
        {
            get { return Manager.Context; }
        }
        
        /// <summary>
        /// Gets the entity for this manager.
        /// </summary>
        protected Table<Item> Entity
        {
            get { return Manager.Context.Item; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        public static IEntityKey<string> CreateKey(string itemId)
        {
            return new EntityKey<string>(itemId);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;string&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;string&gt;.</exception>
        public override Item GetByKey(IEntityKey key)
        {
            if (key is IEntityKey<string>)
            {
                IEntityKey<string> entityKey = (IEntityKey<string>)key;
                return GetByKey(entityKey.Key);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<string>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public Item GetByKey(string itemId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, itemId);
            else
                return Entity.FirstOrDefault(i => i.ItemId == itemId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Item> GetByProductIdItemIdListPriceName(string productId, string itemId, decimal? listPrice, string name)
        {
                return Entity.Where(i => i.ProductId == productId 
					&& i.ItemId == itemId 
					&& i.ListPrice == listPrice 
					&& i.Name == name);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Item> GetByProductId(string productId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByProductId.Invoke(Context, productId);
            else
                return Entity.Where(i => i.ProductId == productId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Item> GetBySupplier(int? supplier)
        {
            if (Context.LoadOptions == null) 
                return Query.GetBySupplier.Invoke(Context, supplier);
            else
                return Entity.Where(i => i.Supplier == supplier);
        }

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddRules();
        /// <summary>Called when the class is created.</summary>
        partial void OnCreated();
        #endregion
        
        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<PetshopDataContext, string, Item> GetByKey = 
                CompiledQuery.Compile(
                    (PetshopDataContext db, string itemId) => 
                        db.Item.FirstOrDefault(i => i.ItemId == itemId));

            internal static readonly Func<PetshopDataContext, string, IQueryable<Item>> GetByProductId = 
                CompiledQuery.Compile(
                    (PetshopDataContext db, string productId) => 
                        db.Item.Where(i => i.ProductId == productId));

            internal static readonly Func<PetshopDataContext, int?, IQueryable<Item>> GetBySupplier = 
                CompiledQuery.Compile(
                    (PetshopDataContext db, int? supplier) => 
                        db.Item.Where(i => i.Supplier == supplier));

        }
        #endregion
    }
}
