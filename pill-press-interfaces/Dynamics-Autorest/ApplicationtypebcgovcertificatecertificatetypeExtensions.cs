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
    /// Extension methods for Applicationtypebcgovcertificatecertificatetype.
    /// </summary>
    public static partial class ApplicationtypebcgovcertificatecertificatetypeExtensions
    {
            /// <summary>
            /// Get bcgov_applicationtype_bcgov_certificate_CertificateType from
            /// bcgov_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovApplicationtypeid'>
            /// key: bcgov_applicationtypeid of bcgov_applicationtype
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
            public static MicrosoftDynamicsCRMbcgovCertificateCollection Get(this IApplicationtypebcgovcertificatecertificatetype operations, string bcgovApplicationtypeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bcgovApplicationtypeid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_applicationtype_bcgov_certificate_CertificateType from
            /// bcgov_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovApplicationtypeid'>
            /// key: bcgov_applicationtypeid of bcgov_applicationtype
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
            public static async Task<MicrosoftDynamicsCRMbcgovCertificateCollection> GetAsync(this IApplicationtypebcgovcertificatecertificatetype operations, string bcgovApplicationtypeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bcgovApplicationtypeid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_applicationtype_bcgov_certificate_CertificateType from
            /// bcgov_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovApplicationtypeid'>
            /// key: bcgov_applicationtypeid of bcgov_applicationtype
            /// </param>
            /// <param name='bcgovCertificateid'>
            /// key: bcgov_certificateid of bcgov_certificate
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovCertificate CertificateTypeByKey(this IApplicationtypebcgovcertificatecertificatetype operations, string bcgovApplicationtypeid, string bcgovCertificateid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.CertificateTypeByKeyAsync(bcgovApplicationtypeid, bcgovCertificateid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_applicationtype_bcgov_certificate_CertificateType from
            /// bcgov_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovApplicationtypeid'>
            /// key: bcgov_applicationtypeid of bcgov_applicationtype
            /// </param>
            /// <param name='bcgovCertificateid'>
            /// key: bcgov_certificateid of bcgov_certificate
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
            public static async Task<MicrosoftDynamicsCRMbcgovCertificate> CertificateTypeByKeyAsync(this IApplicationtypebcgovcertificatecertificatetype operations, string bcgovApplicationtypeid, string bcgovCertificateid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CertificateTypeByKeyWithHttpMessagesAsync(bcgovApplicationtypeid, bcgovCertificateid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}