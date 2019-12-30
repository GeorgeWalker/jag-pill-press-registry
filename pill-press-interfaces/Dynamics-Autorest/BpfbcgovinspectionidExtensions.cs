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
    /// Extension methods for Bpfbcgovinspectionid.
    /// </summary>
    public static partial class BpfbcgovinspectionidExtensions
    {
            /// <summary>
            /// Get bpf_bcgov_inspectionid from bcgov_inspectionprocessflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of bcgov_inspectionprocessflow
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovInspection Get(this IBpfbcgovinspectionid operations, string businessprocessflowinstanceid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(businessprocessflowinstanceid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bpf_bcgov_inspectionid from bcgov_inspectionprocessflows
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of bcgov_inspectionprocessflow
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
            public static async Task<MicrosoftDynamicsCRMbcgovInspection> GetAsync(this IBpfbcgovinspectionid operations, string businessprocessflowinstanceid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(businessprocessflowinstanceid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
