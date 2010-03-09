﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The query extension class for UserRole.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated()]
    public static partial class UserRoleExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Core.Data.UserRole GetByKey(this IQueryable<Tracker.Core.Data.UserRole> queryable, int userId, int roleId)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.UserRole>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, userId, roleId);

            return queryable.FirstOrDefault(u => u.UserId == userId 
					&& u.RoleId == roleId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Core.Data.UserRole> table, int userId, int roleId)
        {
            return table.Delete(u => u.UserId == userId 
					&& u.RoleId == roleId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="userId">UserId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByUserId(this IQueryable<Tracker.Core.Data.UserRole> queryable, int userId)
        {
            return queryable.Where(u => u.UserId == userId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="userId">UserId to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByUserId(this IQueryable<Tracker.Core.Data.UserRole> queryable, int userId, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(u => userId > u.UserId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(u => userId >= u.UserId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(u => userId < u.UserId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(u => userId <= u.UserId);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(u => u.UserId != userId);
                default:
                    return queryable.Where(u => u.UserId == userId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="userId">UserId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByUserId(this IQueryable<Tracker.Core.Data.UserRole> queryable, int userId, params int[] additionalValues)
        {
            var userIdList = new List<int> { userId };

            if (additionalValues != null)
                userIdList.AddRange(additionalValues);

            if (userIdList.Count == 1)
                return queryable.ByUserId(userIdList[0]);

            return queryable.ByUserId(userIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByUserId(this IQueryable<Tracker.Core.Data.UserRole> queryable, IEnumerable<int> values)
        {
            return queryable.Where(u => values.Contains(u.UserId));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.RoleId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="roleId">RoleId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByRoleId(this IQueryable<Tracker.Core.Data.UserRole> queryable, int roleId)
        {
            return queryable.Where(u => u.RoleId == roleId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.RoleId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="roleId">RoleId to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByRoleId(this IQueryable<Tracker.Core.Data.UserRole> queryable, int roleId, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(u => roleId > u.RoleId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(u => roleId >= u.RoleId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(u => roleId < u.RoleId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(u => roleId <= u.RoleId);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(u => u.RoleId != roleId);
                default:
                    return queryable.Where(u => u.RoleId == roleId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.RoleId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="roleId">RoleId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByRoleId(this IQueryable<Tracker.Core.Data.UserRole> queryable, int roleId, params int[] additionalValues)
        {
            var roleIdList = new List<int> { roleId };

            if (additionalValues != null)
                roleIdList.AddRange(additionalValues);

            if (roleIdList.Count == 1)
                return queryable.ByRoleId(roleIdList[0]);

            return queryable.ByRoleId(roleIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.UserRole.RoleId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.UserRole> ByRoleId(this IQueryable<Tracker.Core.Data.UserRole> queryable, IEnumerable<int> values)
        {
            return queryable.Where(u => values.Contains(u.RoleId));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, int, Tracker.Core.Data.UserRole> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int userId, int roleId) =>
                        db.UserRole.FirstOrDefault(u => u.UserId == userId 
							&& u.RoleId == roleId));

        }
        #endregion
    }
}
