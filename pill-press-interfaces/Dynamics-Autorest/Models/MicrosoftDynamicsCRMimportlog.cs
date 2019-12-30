// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.importlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMimportlog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportlog
        /// class.
        /// </summary>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the import log.</param>
        /// <param name="linenumber">Original line number of the data used in
        /// this log.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the importlog.</param>
        /// <param name="errornumber">Error code of an error.</param>
        /// <param name="_owninguserValue">Unique identifier of the user who
        /// owns the import log.</param>
        /// <param name="statecode">Status of the import log.</param>
        /// <param name="errordescription">Description of an error.</param>
        /// <param name="additionalinfo">Additional information related to the
        /// error.</param>
        /// <param name="_owningbusinessunitValue">Business unit that owns the
        /// import log.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the import log.</param>
        /// <param name="sequencenumber">Sequence number of the error in this
        /// log.</param>
        /// <param name="headercolumn">Name of the column heading.</param>
        /// <param name="_owningteamValue">Unique identifier of the team who
        /// owns the import log.</param>
        /// <param name="_importfileidValue">Unique identifier of the import
        /// file for this import log.</param>
        /// <param name="logphasecode">Phase for which the log is
        /// recorded.</param>
        /// <param name="createdon">Date and time when the import log was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the importlog.</param>
        /// <param name="modifiedon">Date and time when the import log was last
        /// modified.</param>
        /// <param name="importlogid">Unique identifier of the import
        /// log.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the import log.</param>
        /// <param name="columnvalue">Value in the column.</param>
        /// <param name="statuscode">Reason for the status of the import
        /// log.</param>
        /// <param name="_importdataidValue">Unique identifier of the import
        /// data for this import log.</param>
        public MicrosoftDynamicsCRMimportlog(string _createdbyValue = default(string), int? linenumber = default(int?), string _modifiedonbehalfbyValue = default(string), int? errornumber = default(int?), string _owninguserValue = default(string), int? statecode = default(int?), string errordescription = default(string), string additionalinfo = default(string), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), int? sequencenumber = default(int?), string headercolumn = default(string), string _owningteamValue = default(string), string _importfileidValue = default(string), int? logphasecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string importlogid = default(string), string _owneridValue = default(string), string columnvalue = default(string), int? statuscode = default(int?), string _importdataidValue = default(string), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> importLogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMimportdata importdataid = default(MicrosoftDynamicsCRMimportdata), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMasyncoperation> importLogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMimportfile importfileid = default(MicrosoftDynamicsCRMimportfile), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._createdbyValue = _createdbyValue;
            Linenumber = linenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Errornumber = errornumber;
            this._owninguserValue = _owninguserValue;
            Statecode = statecode;
            Errordescription = errordescription;
            Additionalinfo = additionalinfo;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Sequencenumber = sequencenumber;
            Headercolumn = headercolumn;
            this._owningteamValue = _owningteamValue;
            this._importfileidValue = _importfileidValue;
            Logphasecode = logphasecode;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Importlogid = importlogid;
            this._owneridValue = _owneridValue;
            Columnvalue = columnvalue;
            Statuscode = statuscode;
            this._importdataidValue = _importdataidValue;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            ImportLogBulkDeleteFailures = importLogBulkDeleteFailures;
            Importdataid = importdataid;
            Modifiedby = modifiedby;
            Owningteam = owningteam;
            ImportLogAsyncOperations = importLogAsyncOperations;
            Importfileid = importfileid;
            Ownerid = ownerid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who created the import
        /// log.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets original line number of the data used in this log.
        /// </summary>
        [JsonProperty(PropertyName = "linenumber")]
        public int? Linenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the importlog.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets error code of an error.
        /// </summary>
        [JsonProperty(PropertyName = "errornumber")]
        public int? Errornumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the import log.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets status of the import log.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets description of an error.
        /// </summary>
        [JsonProperty(PropertyName = "errordescription")]
        public string Errordescription { get; set; }

        /// <summary>
        /// Gets or sets additional information related to the error.
        /// </summary>
        [JsonProperty(PropertyName = "additionalinfo")]
        public string Additionalinfo { get; set; }

        /// <summary>
        /// Gets or sets business unit that owns the import log.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// import log.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the error in this log.
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// Gets or sets name of the column heading.
        /// </summary>
        [JsonProperty(PropertyName = "headercolumn")]
        public string Headercolumn { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns the import log.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the import file for this import
        /// log.
        /// </summary>
        [JsonProperty(PropertyName = "_importfileid_value")]
        public string _importfileidValue { get; set; }

        /// <summary>
        /// Gets or sets phase for which the log is recorded.
        /// </summary>
        [JsonProperty(PropertyName = "logphasecode")]
        public int? Logphasecode { get; set; }

        /// <summary>
        /// Gets or sets date and time when the import log was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// importlog.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the import log was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the import log.
        /// </summary>
        [JsonProperty(PropertyName = "importlogid")]
        public string Importlogid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// import log.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets value in the column.
        /// </summary>
        [JsonProperty(PropertyName = "columnvalue")]
        public string Columnvalue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the import log.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the import data for this import
        /// log.
        /// </summary>
        [JsonProperty(PropertyName = "_importdataid_value")]
        public string _importdataidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportLog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ImportLogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importdataid")]
        public MicrosoftDynamicsCRMimportdata Importdataid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportLog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ImportLogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importfileid")]
        public MicrosoftDynamicsCRMimportfile Importfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
