// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_licencetypestep
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLicencetypestep
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetypestep class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetypestep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetypestep class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetypestep(string adoxioName = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), long? versionnumber = default(long?), int? statuscode = default(int?), string _createdonbehalfbyValue = default(string), bool? adoxioDisableuntilprerequisitescomplete = default(bool?), string _createdbyValue = default(string), string _owningteamValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioLicencetypestepid = default(string), string _adoxioLicencetypeValue = default(string), string _owningbusinessunitValue = default(string), string _adoxioModuleValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), int? adoxioDisplayorder = default(int?), string adoxioStepinstructiontitle = default(string), string adoxioStepinstructions = default(string), string _owninguserValue = default(string), bool? adoxioDisableprerequisitesuponcompletion = default(bool?), string _owneridValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLicencetypestepSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLicencetypestepDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLicencetypestepDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLicencetypestepAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLicencetypestepBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioApplicationmodule adoxioModule = default(MicrosoftDynamicsCRMadoxioApplicationmodule), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceType = default(MicrosoftDynamicsCRMadoxioLicencetype), IList<MicrosoftDynamicsCRMadoxioApplicantstep> adoxioLicencetypestepAdoxioApplicantstepLicenceTypeStep = default(IList<MicrosoftDynamicsCRMadoxioApplicantstep>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioLicencetypestepAdoxioApplicationLastCompletedStep = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioLicencetypestepAdoxioApplicationMarkStepIncomplete = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicencetypestepprerequisite> adoxioLicencetypestepAdoxioLicencetypestepprerequisiteAppliesTo = default(IList<MicrosoftDynamicsCRMadoxioLicencetypestepprerequisite>), IList<MicrosoftDynamicsCRMadoxioLicencetypestepprerequisite> adoxioLicencetypestepAdoxioLicencetypestepprerequisitePrerequisiteStep = default(IList<MicrosoftDynamicsCRMadoxioLicencetypestepprerequisite>))
        {
            AdoxioName = adoxioName;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioDisableuntilprerequisitescomplete = adoxioDisableuntilprerequisitescomplete;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            Createdon = createdon;
            AdoxioLicencetypestepid = adoxioLicencetypestepid;
            this._adoxioLicencetypeValue = _adoxioLicencetypeValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._adoxioModuleValue = _adoxioModuleValue;
            Overriddencreatedon = overriddencreatedon;
            Modifiedon = modifiedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioDisplayorder = adoxioDisplayorder;
            AdoxioStepinstructiontitle = adoxioStepinstructiontitle;
            AdoxioStepinstructions = adoxioStepinstructions;
            this._owninguserValue = _owninguserValue;
            AdoxioDisableprerequisitesuponcompletion = adoxioDisableprerequisitesuponcompletion;
            this._owneridValue = _owneridValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLicencetypestepSyncErrors = adoxioLicencetypestepSyncErrors;
            AdoxioLicencetypestepDuplicateMatchingRecord = adoxioLicencetypestepDuplicateMatchingRecord;
            AdoxioLicencetypestepDuplicateBaseRecord = adoxioLicencetypestepDuplicateBaseRecord;
            AdoxioLicencetypestepAsyncOperations = adoxioLicencetypestepAsyncOperations;
            AdoxioLicencetypestepBulkDeleteFailures = adoxioLicencetypestepBulkDeleteFailures;
            AdoxioModule = adoxioModule;
            AdoxioLicenceType = adoxioLicenceType;
            AdoxioLicencetypestepAdoxioApplicantstepLicenceTypeStep = adoxioLicencetypestepAdoxioApplicantstepLicenceTypeStep;
            AdoxioLicencetypestepAdoxioApplicationLastCompletedStep = adoxioLicencetypestepAdoxioApplicationLastCompletedStep;
            AdoxioLicencetypestepAdoxioApplicationMarkStepIncomplete = adoxioLicencetypestepAdoxioApplicationMarkStepIncomplete;
            AdoxioLicencetypestepAdoxioLicencetypestepprerequisiteAppliesTo = adoxioLicencetypestepAdoxioLicencetypestepprerequisiteAppliesTo;
            AdoxioLicencetypestepAdoxioLicencetypestepprerequisitePrerequisiteStep = adoxioLicencetypestepAdoxioLicencetypestepprerequisitePrerequisiteStep;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_disableuntilprerequisitescomplete")]
        public bool? AdoxioDisableuntilprerequisitescomplete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestepid")]
        public string AdoxioLicencetypestepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetype_value")]
        public string _adoxioLicencetypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_module_value")]
        public string _adoxioModuleValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_displayorder")]
        public int? AdoxioDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_stepinstructiontitle")]
        public string AdoxioStepinstructiontitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_stepinstructions")]
        public string AdoxioStepinstructions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_disableprerequisitesuponcompletion")]
        public bool? AdoxioDisableprerequisitesuponcompletion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLicencetypestepSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLicencetypestepDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLicencetypestepDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLicencetypestepAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLicencetypestepBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Module")]
        public MicrosoftDynamicsCRMadoxioApplicationmodule AdoxioModule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceType")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_adoxio_applicantstep_LicenceTypeStep")]
        public IList<MicrosoftDynamicsCRMadoxioApplicantstep> AdoxioLicencetypestepAdoxioApplicantstepLicenceTypeStep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_adoxio_application_LastCompletedStep")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioLicencetypestepAdoxioApplicationLastCompletedStep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_adoxio_application_MarkStepIncomplete")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioLicencetypestepAdoxioApplicationMarkStepIncomplete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_adoxio_licencetypestepprerequisite_AppliesTo")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetypestepprerequisite> AdoxioLicencetypestepAdoxioLicencetypestepprerequisiteAppliesTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypestep_adoxio_licencetypestepprerequisite_PrerequisiteStep")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetypestepprerequisite> AdoxioLicencetypestepAdoxioLicencetypestepprerequisitePrerequisiteStep { get; set; }

    }
}
