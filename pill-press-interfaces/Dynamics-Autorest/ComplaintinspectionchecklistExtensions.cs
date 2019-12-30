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
    /// Extension methods for Complaintinspectionchecklist.
    /// </summary>
    public static partial class ComplaintinspectionchecklistExtensions
    {
            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovComplaintid'>
            /// key: bcgov_complaintid of bcgov_complaint
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
            public static MicrosoftDynamicsCRMbcgovInspectionchecklistCollection Get(this IComplaintinspectionchecklist operations, string bcgovComplaintid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bcgovComplaintid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovComplaintid'>
            /// key: bcgov_complaintid of bcgov_complaint
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
            public static async Task<MicrosoftDynamicsCRMbcgovInspectionchecklistCollection> GetAsync(this IComplaintinspectionchecklist operations, string bcgovComplaintid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bcgovComplaintid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovComplaintid'>
            /// key: bcgov_complaintid of bcgov_complaint
            /// </param>
            /// <param name='bcgovInspectionchecklistid'>
            /// key: bcgov_inspectionchecklistid of bcgov_inspectionchecklist
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovInspectionchecklist InspectionchecklistByKey(this IComplaintinspectionchecklist operations, string bcgovComplaintid, string bcgovInspectionchecklistid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.InspectionchecklistByKeyAsync(bcgovComplaintid, bcgovInspectionchecklistid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovComplaintid'>
            /// key: bcgov_complaintid of bcgov_complaint
            /// </param>
            /// <param name='bcgovInspectionchecklistid'>
            /// key: bcgov_inspectionchecklistid of bcgov_inspectionchecklist
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
            public static async Task<MicrosoftDynamicsCRMbcgovInspectionchecklist> InspectionchecklistByKeyAsync(this IComplaintinspectionchecklist operations, string bcgovComplaintid, string bcgovInspectionchecklistid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InspectionchecklistByKeyWithHttpMessagesAsync(bcgovComplaintid, bcgovInspectionchecklistid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_inspectionchecklists
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionchecklistid'>
            /// key: bcgov_inspectionchecklistid of bcgov_inspectionchecklist
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
            public static MicrosoftDynamicsCRMbcgovComplaintCollection Get1(this IComplaintinspectionchecklist operations, string bcgovInspectionchecklistid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get1Async(bcgovInspectionchecklistid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_inspectionchecklists
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionchecklistid'>
            /// key: bcgov_inspectionchecklistid of bcgov_inspectionchecklist
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
            public static async Task<MicrosoftDynamicsCRMbcgovComplaintCollection> Get1Async(this IComplaintinspectionchecklist operations, string bcgovInspectionchecklistid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(bcgovInspectionchecklistid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_inspectionchecklists
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionchecklistid'>
            /// key: bcgov_inspectionchecklistid of bcgov_inspectionchecklist
            /// </param>
            /// <param name='bcgovComplaintid'>
            /// key: bcgov_complaintid of bcgov_complaint
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovComplaint InspectionchecklistByKey1(this IComplaintinspectionchecklist operations, string bcgovInspectionchecklistid, string bcgovComplaintid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.InspectionchecklistByKey1Async(bcgovInspectionchecklistid, bcgovComplaintid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_complaint_inspectionchecklist from bcgov_inspectionchecklists
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInspectionchecklistid'>
            /// key: bcgov_inspectionchecklistid of bcgov_inspectionchecklist
            /// </param>
            /// <param name='bcgovComplaintid'>
            /// key: bcgov_complaintid of bcgov_complaint
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
            public static async Task<MicrosoftDynamicsCRMbcgovComplaint> InspectionchecklistByKey1Async(this IComplaintinspectionchecklist operations, string bcgovInspectionchecklistid, string bcgovComplaintid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InspectionchecklistByKey1WithHttpMessagesAsync(bcgovInspectionchecklistid, bcgovComplaintid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
