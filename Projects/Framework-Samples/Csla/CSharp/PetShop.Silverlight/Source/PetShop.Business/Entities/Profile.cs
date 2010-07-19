﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//       Changes to this template will not be lost.
//
//     Template: SwitchableObject.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Rules;

#endregion

namespace PetShop.Business
{
    public partial class Profile
    {
        #region Business Rules

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

        protected static void AddObjectAuthorizationRules()
        {
            //Csla.Rules.BusinessRules.AddRule(typeof(Profile), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"));
            //Csla.Rules.BusinessRules.AddRule(typeof(Profile), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"));
            //Csla.Rules.BusinessRules.AddRule(typeof(Profile), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"));
        }
        #endregion

        #region Custom Factory Methods

        public static Profile GetProfile(string username)
        {
            return DataPortal.Fetch<Profile>(
                new ProfileCriteria { Username = username });
        }

        #endregion

        #region Custom Business Methods

        private static readonly PropertyInfo<CartList> _shoppingCart = RegisterProperty<CartList>(p => p.ShoppingCart, Csla.RelationshipTypes.LazyLoad);
        public CartList ShoppingCart
        {
            get
            {
                if (!FieldManager.FieldExists(_shoppingCart))
                {
                    if (IsNew)
                        LoadProperty(_shoppingCart, PetShop.Business.CartList.NewList());
                    else

                        LoadProperty(_shoppingCart, PetShop.Business.CartList.GetCart(UniqueID, true));
                }

                return GetProperty(_shoppingCart);
            }
        }

        private static readonly PropertyInfo<CartList> _wishList = RegisterProperty<CartList>(p => p.WishList, Csla.RelationshipTypes.LazyLoad);
        public CartList WishList
        {
            get
            {
                if (!FieldManager.FieldExists(_wishList))
                {
                    if (IsNew)
                        LoadProperty(_wishList, PetShop.Business.CartList.NewList());
                    else

                        LoadProperty(_wishList, PetShop.Business.CartList.GetCart(UniqueID, false));
                }

                return GetProperty(_wishList);
            }
        }

        #endregion
    }
}