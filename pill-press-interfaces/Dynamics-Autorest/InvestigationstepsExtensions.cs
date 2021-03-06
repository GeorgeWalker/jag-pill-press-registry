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
    /// Extension methods for Investigationsteps.
    /// </summary>
    public static partial class InvestigationstepsExtensions
    {
            /// <summary>
            /// Get entities from bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static MicrosoftDynamicsCRMbcgovInvestigationstepCollection Get(this IInvestigationsteps operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static async Task<MicrosoftDynamicsCRMbcgovInvestigationstepCollection> GetAsync(this IInvestigationsteps operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMbcgovInvestigationstep Create(this IInvestigationsteps operations, MicrosoftDynamicsCRMbcgovInvestigationstep body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMbcgovInvestigationstep> CreateAsync(this IInvestigationsteps operations, MicrosoftDynamicsCRMbcgovInvestigationstep body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from bcgov_investigationsteps by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovInvestigationstep GetByKey(this IInvestigationsteps operations, string bcgovInvestigationstepid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(bcgovInvestigationstepid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from bcgov_investigationsteps by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
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
            public static async Task<MicrosoftDynamicsCRMbcgovInvestigationstep> GetByKeyAsync(this IInvestigationsteps operations, string bcgovInvestigationstepid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(bcgovInvestigationstepid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update entity in bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IInvestigationsteps operations, string bcgovInvestigationstepid, MicrosoftDynamicsCRMbcgovInvestigationstep body)
            {
                operations.UpdateAsync(bcgovInvestigationstepid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IInvestigationsteps operations, string bcgovInvestigationstepid, MicrosoftDynamicsCRMbcgovInvestigationstep body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(bcgovInvestigationstepid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IInvestigationsteps operations, string bcgovInvestigationstepid, string ifMatch = default(string))
            {
                operations.DeleteAsync(bcgovInvestigationstepid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IInvestigationsteps operations, string bcgovInvestigationstepid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(bcgovInvestigationstepid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
