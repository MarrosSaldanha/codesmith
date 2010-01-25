//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Inventory.cs'.
//
//     Template: EditableRoot.DataAccess.ParameterizedSQL.cst
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

namespace PetShop.Business
{
    public partial class Inventory
    {
        [RunLocal]
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        protected void DataPortal_Fetch(InventoryCriteria criteria)
        {
            string commandText = string.Format("SELECT [ItemId], [Qty] FROM [dbo].[Inventory] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
							Map(reader);
						else
							throw new Exception(String.Format("The record was not found in 'Inventory' using the following criteria: {0}.", criteria));
                    }
                }
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            const string commandText = "INSERT INTO [dbo].[Inventory] ([ItemId], [Qty]) VALUES (@p_ItemId, @p_Qty)";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
					command.Parameters.AddWithValue("@p_ItemId", ItemId);
					command.Parameters.AddWithValue("@p_Qty", Qty);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                        }
                    }
                }
            }

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            const string commandText = "UPDATE [dbo].[Inventory]  SET [ItemId] = @p_ItemId, [Qty] = @p_Qty WHERE [ItemId] = @p_ItemId";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
					command.Parameters.AddWithValue("@p_ItemId", ItemId);
					command.Parameters.AddWithValue("@p_Qty", Qty);

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        //RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        if(reader.RecordsAffected == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    }
                }
            }

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new InventoryCriteria(ItemId));
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(InventoryCriteria criteria)
        {
            string commandText = string.Format("DELETE FROM [dbo].[Inventory] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        //RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        if(reader.RecordsAffected == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                    }
                }
            }
        }

        private void Map(SafeDataReader reader)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_itemIdProperty, reader.GetString("ItemId"));
                LoadProperty(_qtyProperty, reader.GetInt32("Qty"));
            }

            MarkOld();
        }
    }
}