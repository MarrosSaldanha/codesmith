﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderList.cs'.
//
//     Template: EditableRootList.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    public partial class OrderList
    {
        [RunLocal]
        protected override void DataPortal_Create()
        {
        }

        private void DataPortal_Fetch(OrderCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            string commandText = string.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(new Order(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();
        }

        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            for (int index = 0; index < DeletedList.Count; index++)
            {
                DeletedList[index] = DeletedList[index].Save();
            }
           
            DeletedList.Clear();

            for (int index = 0; index < Items.Count; index++)
            {
                Items[index] = Items[index].Save();
            }

            RaiseListChangedEvents = true;

            OnUpdated();
        }
    }
}
