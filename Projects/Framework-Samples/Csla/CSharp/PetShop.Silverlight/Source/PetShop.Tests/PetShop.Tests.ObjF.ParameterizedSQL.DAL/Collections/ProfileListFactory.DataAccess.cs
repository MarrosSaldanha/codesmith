//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
//
//     Template: ObjectFactoryList.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Server;
using Csla.Data;

using PetShop.Tests.ObjF.ParameterizedSQL;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL.DAL
{
    public partial class ProfileListFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new ProfileList with default values.
        /// </summary>
        /// <returns>new ProfileList.</returns>
        [RunLocal]
        public ProfileList Create()
        {
            var item = (ProfileList)Activator.CreateInstance(typeof(ProfileList), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch ProfileList.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public ProfileList Fetch(ProfileCriteria criteria)
        {
            ProfileList item = (ProfileList)Activator.CreateInstance(typeof(ProfileList), true);

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return item;

            string commandText = string.Format("SELECT [UniqueID], [Username], [ApplicationName], [IsAnonymous], [LastActivityDate], [LastUpdatedDate] FROM [dbo].[Profiles] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                        {
                            do
                            {
                                item.Add(new ProfileFactory().Map(reader));
                            } while(reader.Read());
                        }
                        else
                            throw new Exception(String.Format("The record was not found in 'Profiles' using the following criteria: {0}.", criteria));
                    }
                }
            }

            MarkOld(item);
            OnFetched();
            return item;
        }

        #endregion

        #region Data access partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(ref bool cancel);
        partial void OnMapped();

        #endregion
    }
}