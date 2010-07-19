﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderStatusList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;

using Csla;
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class OrderStatusList : BusinessListBase< OrderStatusList, OrderStatus >
    {
        #region Constructor(s)

#if !SILVERLIGHT
        private OrderStatusList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
#else
        public OrderStatusList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
#endif
        
        #endregion

#if !SILVERLIGHT
        #region Synchronous Factory Methods 
        
        internal static OrderStatusList NewList()
        {
            return DataPortal.CreateChild< OrderStatusList >();
        }     

        internal static OrderStatusList GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
			var criteria = new OrderStatusCriteria{OrderId = orderId, LineNum = lineNum};
			
            
            return DataPortal.FetchChild< OrderStatusList >(criteria);
        }

        internal static OrderStatusList GetByOrderId(System.Int32 orderId)
        {
			var criteria = new OrderStatusCriteria{OrderId = orderId};
			
            
            return DataPortal.FetchChild< OrderStatusList >(criteria);
        }

        internal static OrderStatusList GetAll()
        {
            return DataPortal.FetchChild< OrderStatusList >(new OrderStatusCriteria());
        }

		#endregion

#endif  
        #region Asynchronous Factory Methods
        
        internal static void NewOrderStatusListAsync(EventHandler<DataPortalResult<OrderStatus>> handler)
		{
			var dp = new DataPortal<OrderStatus>();
			dp.CreateCompleted += handler;
			dp.BeginCreate();
		}
        
        //Child objects do not expose asynchronous factory get methods
 
        #endregion
        
        #region Method Overrides
        
#if !SILVERLIGHT
        protected override OrderStatus AddNewCore()
        {
            OrderStatus item = PetShop.Business.OrderStatus.NewOrderStatus();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.OrderStatus.NewOrderStatus();

                // Pass the parent value down to the child.
                Order order = this.Parent as Order;
                if(order != null)
                    item.OrderId = order.OrderId;


                Add(item);
            }

            return item;
        }
#else
        protected override void AddNewCore()
        {
            OrderStatus item = PetShop.Business.OrderStatus.NewOrderStatus();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.OrderStatus.NewOrderStatus();

                // Pass the parent value down to the child.
                Order order = this.Parent as Order;
                if(order != null)
                    item.OrderId = order.OrderId;


                Add(item);
            }
        }
#endif
		protected void AddNewCoreAsync(EventHandler<DataPortalResult<object>> handler)
		{
			PetShop.Business.OrderStatus.NewOrderStatusAsync((o, e) =>
			{
				if(e.Error == null)
				{
					Add(e.Object);
					handler.Invoke(this, new DataPortalResult<object>(e.Object, null, null));
				}
			});
		}

        
        #endregion

        #region DataPortal partial methods

#if !SILVERLIGHT
        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(OrderStatusCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref OrderStatus item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT
        public static bool Exists(OrderStatusCriteria criteria)
        {
            return PetShop.Business.OrderStatus.Exists(criteria);
        }
#endif

        #endregion

    }
}