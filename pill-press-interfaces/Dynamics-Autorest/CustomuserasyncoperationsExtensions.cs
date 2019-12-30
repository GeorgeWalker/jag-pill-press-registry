// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Customuserasyncoperations.
    /// </summary>
    public static partial class CustomuserasyncoperationsExtensions
    {
            /// <summary>
            /// Get bcgov_customuser_AsyncOperations from bcgov_customusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovCustomuserid'>
            /// key: bcgov_customuserid of bcgov_customuser
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMasyncoperationCollection Get(this ICustomuserasyncoperations operations, string bcgovCustomuserid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bcgovCustomuserid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_customuser_AsyncOperations from bcgov_customusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovCustomuserid'>
            /// key: bcgov_customuserid of bcgov_customuser
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMasyncoperationCollection> GetAsync(this ICustomuserasyncoperations operations, string bcgovCustomuserid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bcgovCustomuserid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_customuser_AsyncOperations from bcgov_customusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovCustomuserid'>
            /// key: bcgov_customuserid of bcgov_customuser
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMasyncoperation AsyncOperationsByKey(this ICustomuserasyncoperations operations, string bcgovCustomuserid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.AsyncOperationsByKeyAsync(bcgovCustomuserid, asyncoperationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_customuser_AsyncOperations from bcgov_customusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovCustomuserid'>
            /// key: bcgov_customuserid of bcgov_customuser
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMasyncoperation> AsyncOperationsByKeyAsync(this ICustomuserasyncoperations operations, string bcgovCustomuserid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AsyncOperationsByKeyWithHttpMessagesAsync(bcgovCustomuserid, asyncoperationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
