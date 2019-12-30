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
    /// Extension methods for Riskassessmentsharepointdocumentlocations.
    /// </summary>
    public static partial class RiskassessmentsharepointdocumentlocationsExtensions
    {
            /// <summary>
            /// Get bcgov_riskassessment_SharePointDocumentLocations from
            /// bcgov_riskassessments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovRiskassessmentid'>
            /// key: bcgov_riskassessmentid of bcgov_riskassessment
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
            public static MicrosoftDynamicsCRMsharepointdocumentlocationCollection Get(this IRiskassessmentsharepointdocumentlocations operations, string bcgovRiskassessmentid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bcgovRiskassessmentid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_riskassessment_SharePointDocumentLocations from
            /// bcgov_riskassessments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovRiskassessmentid'>
            /// key: bcgov_riskassessmentid of bcgov_riskassessment
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
            public static async Task<MicrosoftDynamicsCRMsharepointdocumentlocationCollection> GetAsync(this IRiskassessmentsharepointdocumentlocations operations, string bcgovRiskassessmentid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bcgovRiskassessmentid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_riskassessment_SharePointDocumentLocations from
            /// bcgov_riskassessments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovRiskassessmentid'>
            /// key: bcgov_riskassessmentid of bcgov_riskassessment
            /// </param>
            /// <param name='sharepointdocumentlocationid'>
            /// key: sharepointdocumentlocationid of sharepointdocumentlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsharepointdocumentlocation SharePointDocumentLocationsByKey(this IRiskassessmentsharepointdocumentlocations operations, string bcgovRiskassessmentid, string sharepointdocumentlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.SharePointDocumentLocationsByKeyAsync(bcgovRiskassessmentid, sharepointdocumentlocationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_riskassessment_SharePointDocumentLocations from
            /// bcgov_riskassessments
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovRiskassessmentid'>
            /// key: bcgov_riskassessmentid of bcgov_riskassessment
            /// </param>
            /// <param name='sharepointdocumentlocationid'>
            /// key: sharepointdocumentlocationid of sharepointdocumentlocation
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
            public static async Task<MicrosoftDynamicsCRMsharepointdocumentlocation> SharePointDocumentLocationsByKeyAsync(this IRiskassessmentsharepointdocumentlocations operations, string bcgovRiskassessmentid, string sharepointdocumentlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SharePointDocumentLocationsByKeyWithHttpMessagesAsync(bcgovRiskassessmentid, sharepointdocumentlocationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
