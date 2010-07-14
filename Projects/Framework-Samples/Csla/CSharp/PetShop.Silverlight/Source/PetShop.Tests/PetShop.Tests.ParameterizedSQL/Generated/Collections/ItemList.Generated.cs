﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ItemList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class ItemList : BusinessListBase< ItemList, Item >
    {
        #region Factory Methods 
        
        internal static ItemList NewList()
        {
            return DataPortal.CreateChild< ItemList >();
        }

        internal static ItemList GetByItemId(System.String itemId)
        {
            return DataPortal.FetchChild< ItemList >(
                new ItemCriteria{ItemId = itemId});
        }

        internal static ItemList GetByProductIdItemIdListPriceName(System.String productId, System.String itemId, System.Decimal? listPrice, System.String name)
        {
            return DataPortal.FetchChild< ItemList >(
                new ItemCriteria{ProductId = productId, ItemId = itemId, ListPrice = listPrice.Value, Name = name});
        }

        internal static ItemList GetByProductId(System.String productId)
        {
            return DataPortal.FetchChild< ItemList >(
                new ItemCriteria{ProductId = productId});
        }

        internal static ItemList GetBySupplier(System.Int32? supplier)
        {
            return DataPortal.FetchChild< ItemList >(
                new ItemCriteria{Supplier = supplier.Value});
        }

        internal static ItemList GetAll()
        {
            return DataPortal.FetchChild< ItemList >(new ItemCriteria());
        }

        private ItemList()
        {
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Properties
        
        protected override object AddNewCore()
        {
            Item item = PetShop.Tests.ParameterizedSQL.Item.NewItem();
            Add(item);
            return item;
        }
        
        #endregion


        #region Exists Command

        public static bool Exists(ItemCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.Item.Exists(criteria);
        }

        #endregion
    }
}