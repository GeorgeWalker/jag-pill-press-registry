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
    /// Extension methods for Investigationsteprecurringappointmentmasters.
    /// </summary>
    public static partial class InvestigationsteprecurringappointmentmastersExtensions
    {
            /// <summary>
            /// Get bcgov_investigationstep_RecurringAppointmentMasters from
            /// bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
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
            public static MicrosoftDynamicsCRMrecurringappointmentmasterCollection Get(this IInvestigationsteprecurringappointmentmasters operations, string bcgovInvestigationstepid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bcgovInvestigationstepid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_investigationstep_RecurringAppointmentMasters from
            /// bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
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
            public static async Task<MicrosoftDynamicsCRMrecurringappointmentmasterCollection> GetAsync(this IInvestigationsteprecurringappointmentmasters operations, string bcgovInvestigationstepid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bcgovInvestigationstepid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_investigationstep_RecurringAppointmentMasters from
            /// bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of recurringappointmentmaster
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMrecurringappointmentmaster RecurringAppointmentMastersByKey(this IInvestigationsteprecurringappointmentmasters operations, string bcgovInvestigationstepid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.RecurringAppointmentMastersByKeyAsync(bcgovInvestigationstepid, activityid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_investigationstep_RecurringAppointmentMasters from
            /// bcgov_investigationsteps
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovInvestigationstepid'>
            /// key: bcgov_investigationstepid of bcgov_investigationstep
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of recurringappointmentmaster
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
            public static async Task<MicrosoftDynamicsCRMrecurringappointmentmaster> RecurringAppointmentMastersByKeyAsync(this IInvestigationsteprecurringappointmentmasters operations, string bcgovInvestigationstepid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RecurringAppointmentMastersByKeyWithHttpMessagesAsync(bcgovInvestigationstepid, activityid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
