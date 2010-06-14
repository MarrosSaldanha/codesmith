﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: DynamicRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class ProductList : EditableRootListBase< Product >
    {
        #region Properties
        
        protected override object AddNewCore()
        {
            Product item = PetShop.Business.Product.NewProduct();
            Add(item);
            return item;
        }
        
        #endregion

        #region Factory Methods 
        
        public static ProductList NewList()
        {
            return DataPortal.Create< ProductList >();
        }

        public static ProductList GetAll()
        {
            return DataPortal.Fetch< ProductList >(new ProductCriteria());
        }

        public static ProductList GetByProductId(System.String productId)
        {
            return DataPortal.Fetch< ProductList >(
                new ProductCriteria{ProductId = productId});
        }

        public static ProductList GetByName(System.String name)
        {
            return DataPortal.Fetch< ProductList >(
                new ProductCriteria{Name = name});
        }

        public static ProductList GetByCategoryId(System.String categoryId)
        {
            return DataPortal.Fetch< ProductList >(
                new ProductCriteria{CategoryId = categoryId});
        }

        public static ProductList GetByCategoryIdName(System.String categoryId, System.String name)
        {
            return DataPortal.Fetch< ProductList >(
                new ProductCriteria{CategoryId = categoryId, Name = name});
        }

        public static ProductList GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
            return DataPortal.Fetch< ProductList >(
                new ProductCriteria{CategoryId = categoryId, ProductId = productId, Name = name});
        }

        private ProductList()
        { 
            AllowNew = true;
        }
        
        #endregion


        #region Exists Command

        public static bool Exists(ProductCriteria criteria)
        {
            return PetShop.Business.Product.Exists(criteria);
        }

        #endregion
    }
}