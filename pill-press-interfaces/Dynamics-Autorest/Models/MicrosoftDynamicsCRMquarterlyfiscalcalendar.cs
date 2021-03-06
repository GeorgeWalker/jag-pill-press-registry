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
    /// Microsoft.Dynamics.CRM.quarterlyfiscalcalendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMquarterlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMquarterlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMquarterlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMquarterlyfiscalcalendar class.
        /// </summary>
        /// <param name="fiscalperiodtype">Type of fiscal period used in the
        /// sales quota.</param>
        /// <param name="quarter4">Sales quota for the fourth quarter in the
        /// fiscal year.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the quarterly fiscal calendar.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="quarter1">Sales quota for the first quarter in the
        /// fiscal year.</param>
        /// <param name="createdon">Date and time when the quota for the
        /// quarterly fiscal calendar was created.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the quarterly fiscal calendar.</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the quarterly fiscal calendar.</param>
        /// <param name="quarter3">Sales quota for the third quarter in the
        /// fiscal year.</param>
        /// <param name="_salespersonidValue">Unique identifier of the
        /// associated salesperson.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the quarterlyfiscalcalendar.</param>
        /// <param name="userfiscalcalendarid">Unique identifier of the
        /// quarterly fiscal calendar.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the
        /// quarterlyfiscalcalendar.</param>
        /// <param name="quarter2">Sales quota for the second quarter in the
        /// fiscal year.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the quarterly fiscal calendar with respect to the
        /// base currency.</param>
        /// <param name="quarter4Base">Base currency equivalent of the sales
        /// quota for the fourth quarter in the fiscal year.</param>
        /// <param name="quarter2Base">Base currency equivalent of the sales
        /// quota for the second quarter in the fiscal year</param>
        /// <param name="quarter1Base">Base currency equivalent of the sales
        /// quota for the first quarter in the fiscal year.</param>
        /// <param name="effectiveon">Date and time when the quarterly fiscal
        /// calendar sales quota takes effect.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="modifiedon">Date and time when the quarterly fiscal
        /// calendar was last modified.</param>
        /// <param name="quarter3Base">Base currency equivalent of the sales
        /// quota for the third quarter in the fiscal year.</param>
        public MicrosoftDynamicsCRMquarterlyfiscalcalendar(int? fiscalperiodtype = default(int?), decimal? quarter4 = default(decimal?), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), decimal? quarter1 = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _transactioncurrencyidValue = default(string), decimal? quarter3 = default(decimal?), string _salespersonidValue = default(string), string _createdonbehalfbyValue = default(string), string userfiscalcalendarid = default(string), string _modifiedonbehalfbyValue = default(string), decimal? quarter2 = default(decimal?), decimal? exchangerate = default(decimal?), decimal? quarter4Base = default(decimal?), string _businessunitidValue = default(string), decimal? quarter2Base = default(decimal?), decimal? quarter1Base = default(decimal?), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), decimal? quarter3Base = default(decimal?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMasyncoperation> quarterlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quarterlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser))
        {
            Fiscalperiodtype = fiscalperiodtype;
            Quarter4 = quarter4;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Quarter1 = quarter1;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Quarter3 = quarter3;
            this._salespersonidValue = _salespersonidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Userfiscalcalendarid = userfiscalcalendarid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Quarter2 = quarter2;
            Exchangerate = exchangerate;
            Quarter4Base = quarter4Base;
            this._businessunitidValue = _businessunitidValue;
            Quarter2Base = quarter2Base;
            Quarter1Base = quarter1Base;
            Effectiveon = effectiveon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            Quarter3Base = quarter3Base;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Transactioncurrencyid = transactioncurrencyid;
            QuarterlyFiscalCalendarAsyncOperations = quarterlyFiscalCalendarAsyncOperations;
            QuarterlyFiscalCalendarBulkDeleteFailures = quarterlyFiscalCalendarBulkDeleteFailures;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Salespersonid = salespersonid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of fiscal period used in the sales quota.
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// Gets or sets sales quota for the fourth quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter4")]
        public decimal? Quarter4 { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the
        /// quarterly fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets sales quota for the first quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter1")]
        public decimal? Quarter1 { get; set; }

        /// <summary>
        /// Gets or sets date and time when the quota for the quarterly fiscal
        /// calendar was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// quarterly fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// quarterly fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets sales quota for the third quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter3")]
        public decimal? Quarter3 { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated salesperson.
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// quarterlyfiscalcalendar.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the quarterly fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the quarterlyfiscalcalendar.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets sales quota for the second quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter2")]
        public decimal? Quarter2 { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// quarterly fiscal calendar with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets base currency equivalent of the sales quota for the
        /// fourth quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter4_base")]
        public decimal? Quarter4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// Gets or sets base currency equivalent of the sales quota for the
        /// second quarter in the fiscal year
        /// </summary>
        [JsonProperty(PropertyName = "quarter2_base")]
        public decimal? Quarter2Base { get; set; }

        /// <summary>
        /// Gets or sets base currency equivalent of the sales quota for the
        /// first quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter1_base")]
        public decimal? Quarter1Base { get; set; }

        /// <summary>
        /// Gets or sets date and time when the quarterly fiscal calendar sales
        /// quota takes effect.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets date and time when the quarterly fiscal calendar was
        /// last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets base currency equivalent of the sales quota for the
        /// third quarter in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "quarter3_base")]
        public decimal? Quarter3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuarterlyFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuarterlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuarterlyFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuarterlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

    }
}
