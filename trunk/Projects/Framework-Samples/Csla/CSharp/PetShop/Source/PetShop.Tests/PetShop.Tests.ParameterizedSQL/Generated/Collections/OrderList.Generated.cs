﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class OrderList : BusinessListBase< OrderList, Order >
    {    
        #region Contructor(s)

        private OrderList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Method Overrides
        
        protected override object AddNewCore()
        {
            Order item = PetShop.Tests.ParameterizedSQL.Order.NewOrder();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ParameterizedSQL.Order.NewOrder();


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        public static OrderList NewList()
        {
            return DataPortal.Create< OrderList >();
        }      

        public static OrderList GetByOrderId(System.Int32 orderId)
        {
			var criteria = new OrderCriteria{OrderId = orderId};
			
			
            return DataPortal.Fetch< OrderList >(criteria);
        }
        

        public static OrderList GetAll()
        {
            return DataPortal.Fetch< OrderList >(new OrderCriteria());
        }

        #endregion



        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(OrderCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Order item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(OrderCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.Order.Exists(criteria);
        }

        #endregion

    }
}