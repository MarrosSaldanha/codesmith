//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1357, CSLA Framework: v3.8.0.
//       Changes to this template will not be lost.
//
//     Template: EditableRoot.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Validation;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    public partial class Supplier
    {
        #region Validation Rules

        /// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
        protected bool AddBusinessValidationRules()
        {
            // TODO: add validation rules
            //ValidationRules.AddRule(RuleMethod, "");

            return false;
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(Supplier), admin);
            // AuthorizationRules.AllowDelete(typeof(Supplier), admin);
            // AuthorizationRules.AllowEdit(typeof(Supplier), canWrite);
            // AuthorizationRules.AllowGet(typeof(Supplier), canRead);

            //// SuppId
            // AuthorizationRules.AllowRead(_suppIdProperty, canRead);

            //// Name
            // AuthorizationRules.AllowRead(_nameProperty, canRead);

            //// Status
            // AuthorizationRules.AllowRead(_statusProperty, canRead);

            //// Addr1
            // AuthorizationRules.AllowRead(_addr1Property, canRead);

            //// Addr2
            // AuthorizationRules.AllowRead(_addr2Property, canRead);

            //// City
            // AuthorizationRules.AllowRead(_cityProperty, canRead);

            //// State
            // AuthorizationRules.AllowRead(_stateProperty, canRead);

            //// Zip
            // AuthorizationRules.AllowRead(_zipProperty, canRead);

            //// Phone
            // AuthorizationRules.AllowRead(_phoneProperty, canRead);

// NOTE: Many-To-Many support coming soon.
            //// Items
            // AuthorizationRules.AllowRead(_itemsProperty, canRead);

        }

        #endregion
    }
}