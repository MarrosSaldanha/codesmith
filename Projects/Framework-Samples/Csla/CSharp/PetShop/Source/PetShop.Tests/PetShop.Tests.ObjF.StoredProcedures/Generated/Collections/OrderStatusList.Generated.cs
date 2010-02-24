﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
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

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.OrderStatusListFactoryName)]
    public partial class OrderStatusList : BusinessListBase< OrderStatusList, OrderStatus >
    {
        #region Factory Methods 
        
        internal static OrderStatusList NewList()
        {
            return DataPortal.CreateChild< OrderStatusList >();
        }

        internal static OrderStatusList GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            return DataPortal.FetchChild< OrderStatusList >(
                new OrderStatusCriteria{OrderId = orderId, LineNum = lineNum});
        }

        internal static OrderStatusList GetByOrderId(System.Int32 orderId)
        {
            return DataPortal.FetchChild< OrderStatusList >(
                new OrderStatusCriteria{OrderId = orderId});
        }

        internal static OrderStatusList GetAll()
        {
            return DataPortal.FetchChild< OrderStatusList >(new OrderStatusCriteria());
        }

        private OrderStatusList()
        {
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Properties
        
        protected override object AddNewCore()
        {
            OrderStatus item = PetShop.Tests.ObjF.StoredProcedures.OrderStatus.NewOrderStatus();
            Add(item);
            return item;
        }
        
        #endregion

        #region Property overrides

        /// <summary>
        /// Returns true if any children are dirty
        /// </summary>
        public new bool IsDirty
        {
            get
            {
                foreach(OrderStatus item in this.Items)
                {
                    if(item.IsDirty) return true;
                }
                
                return false;
            }
        }

        #endregion


        #region Exists Command

        public static bool Exists(OrderStatusCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.OrderStatus.Exists(criteria);
        }

        #endregion
    }
}