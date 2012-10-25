﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProfileList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Threading.Tasks;

using Csla;
#if SILVERLIGHT || NETFX_CORE
using Csla.Serialization;
#else
using Csla.Data;
#endif

namespace PetShop.Business
{
    [Serializable]
    public partial class ProfileList : BusinessListBase<ProfileList, Profile>
    {    
        #region Contructor(s)

        public ProfileList()
        { 
            AllowNew = true;
        }

        #endregion

        #region Method Overrides
#if !SILVERLIGHT && !NETFX_CORE
        protected override Profile AddNewCore()
        {
            Profile item = PetShop.Business.Profile.NewProfileChild();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Profile.NewProfileChild();


                Add(item);
            }

            return item;
        }
#else
        protected override void AddNewCore()
        {
            PetShop.Business.Profile.NewProfileChildAsync().ContinueWith(t => 
            {
                Profile item = t.Result;

                bool cancel = false;
                OnAddNewCore(ref item, ref cancel);
                if (!cancel)
                {
                    // Check to see if someone set the item to null in the OnAddNewCore.
                    if(item == null)
                        return;
                    Add(item);
                }
            });
        }
#endif
        
        #endregion

        #region Synchronous Factory Methods 
#if !SILVERLIGHT && !NETFX_CORE

        /// <summary>
        /// Creates a new object of type <see cref="ProfileList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="ProfileList"/>.</returns>
        public static ProfileList NewList()
        {
            return DataPortal.Create<ProfileList>();
        }      

        /// <summary>
        /// Returns a <see cref="ProfileList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="uniqueID">No additional detail available.</param>
        /// <returns>A <see cref="ProfileList"/> object of the specified criteria.</returns>
        public static ProfileList GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new ProfileCriteria{UniqueID = uniqueID};
            
            
            return DataPortal.Fetch<ProfileList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ProfileList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="username">No additional detail available.</param>
        /// <param name="applicationName">No additional detail available.</param>
        /// <returns>A <see cref="ProfileList"/> object of the specified criteria.</returns>
        public static ProfileList GetByUsernameApplicationName(System.String username, System.String applicationName)
        {
            var criteria = new ProfileCriteria{Username = username, ApplicationName = applicationName};
            
            
            return DataPortal.Fetch<ProfileList>(criteria);
        }

        public static ProfileList GetByCriteria(ProfileCriteria criteria)
        {
            return DataPortal.Fetch<ProfileList>(criteria);
        }
        
        public static ProfileList GetAll()
        {
            return DataPortal.Fetch<ProfileList>(new ProfileCriteria());
        }

#endif
        #endregion

        #region Asynchronous Factory Methods

        public static async Task<ProfileList> NewListAsync()
        {
            return await DataPortal.CreateAsync<ProfileList>();
        }


        public static async Task<ProfileList> GetByUniqueIDAsync(System.Int32 uniqueID)
        {
            var criteria = new ProfileCriteria{UniqueID = uniqueID};
            
            
            return await DataPortal.FetchAsync<ProfileList>(criteria);
        }

        public static async Task<ProfileList> GetByUsernameApplicationNameAsync(System.String username, System.String applicationName)
        {
            var criteria = new ProfileCriteria{Username = username, ApplicationName = applicationName};
            
            
            return await DataPortal.FetchAsync<ProfileList>(criteria);
        }

        public static async Task<ProfileList> GetByCriteriaAsync(ProfileCriteria criteria)
        {  
            return await DataPortal.FetchAsync<ProfileList>(criteria);
        }

        public static async Task<ProfileList> GetAllAsync()
        {
            return await DataPortal.FetchAsync<ProfileList>(new ProfileCriteria());
        }

        #endregion

        #region DataPortal partial methods

#if !SILVERLIGHT && !NETFX_CORE
        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProfileCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref Profile item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT && !NETFX_CORE
        /// <summary>
        /// Determines if a record exists in the Profile in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="ProfileList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(ProfileCriteria criteria)
        {
            return PetShop.Business.Profile.Exists(criteria);
        }
#endif
        /// <summary>
        /// Determines if a record exists in the Profile in the database for the specified criteria. 
        /// </summary>
        public static async Task<bool> ExistsAsync(ProfileCriteria criteria)
        {
            return await PetShop.Business.ExistsCommand.ExecuteAsync(criteria);
        }

        #endregion
 
        #region Enhancements

        public Profile GetProfile(System.Int32 uniqueID)
        {
            return this.FirstOrDefault(i => i.UniqueID == uniqueID);
        }

        public bool Contains(System.Int32 uniqueID)
        {
            return this.Count(i => i.UniqueID == uniqueID) > 0;
        }
 
        public bool ContainsDeleted(System.Int32 uniqueID)
        {
            return DeletedList.Count(i => i.UniqueID == uniqueID) > 0;
        }
        
        public void Remove(System.Int32 uniqueID)
        {
            var item = this.FirstOrDefault(i => i.UniqueID == uniqueID);
            if (item != null)
                Remove(item);
        }

        #endregion
    }
}