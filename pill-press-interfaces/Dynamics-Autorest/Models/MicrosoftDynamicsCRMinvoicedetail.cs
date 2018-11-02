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
    /// invoicedetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvoicedetail
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoicedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoicedetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoicedetail
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoicedetail(bool? ispriceoverridden = default(bool?), object priceperunit = default(object), string _modifiedonbehalfbyValue = default(string), string _salesrepidValue = default(string), string shiptoTelephone = default(string), object volumediscountamount = default(object), int? sequencenumber = default(int?), string shiptoCountry = default(string), long? versionnumber = default(long?), bool? isproductoverridden = default(bool?), object extendedamountBase = default(object), bool? invoiceispricelocked = default(bool?), string _productidValue = default(string), object taxBase = default(object), string _uomidValue = default(string), object extendedamount = default(object), string owningbusinessunit = default(string), string _createdbyValue = default(string), object volumediscountamountBase = default(object), int? lineitemnumber = default(int?), string parentbundleid = default(string), object manualdiscountamountBase = default(object), string shiptoStateorprovince = default(string), object baseamount = default(object), string productassociationid = default(string), System.DateTimeOffset? actualdeliveryon = default(System.DateTimeOffset?), object priceperunitBase = default(object), bool? iscopied = default(bool?), object quantitybackordered = default(object), object manualdiscountamount = default(object), string invoicedetailid = default(string), string owninguser = default(string), string shiptoCity = default(string), int? invoicestatecode = default(int?), string _createdonbehalfbyValue = default(string), string description = default(string), int? propertyconfigurationstatus = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string shiptoName = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), int? shiptoFreighttermscode = default(int?), int? importsequencenumber = default(int?), int? producttypecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string shiptoLine2 = default(string), int? pricingerrorcode = default(int?), string shippingtrackingnumber = default(string), string shiptoPostalcode = default(string), bool? willcall = default(bool?), int? utcconversiontimezonecode = default(int?), string productdescription = default(string), int? timezoneruleversionnumber = default(int?), string shiptoLine1 = default(string), string shiptoLine3 = default(string), string _invoiceidValue = default(string), object tax = default(object), object baseamountBase = default(object), string _modifiedbyValue = default(string), object quantitycancelled = default(object), object exchangerate = default(object), object quantityshipped = default(object), string _owneridValue = default(string), object quantity = default(object), string shiptoFax = default(string), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> invoiceDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMsystemuser salesrepid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> invoiceDetailDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), IList<MicrosoftDynamicsCRMsyncerror> invoiceDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> invoiceDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMinvoice invoiceid = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMinvoicedetail parentbundleidInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), IList<MicrosoftDynamicsCRMinvoicedetail> invoicedetailParentInvoicedetail = default(IList<MicrosoftDynamicsCRMinvoicedetail>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Ispriceoverridden = ispriceoverridden;
            Priceperunit = priceperunit;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._salesrepidValue = _salesrepidValue;
            ShiptoTelephone = shiptoTelephone;
            Volumediscountamount = volumediscountamount;
            Sequencenumber = sequencenumber;
            ShiptoCountry = shiptoCountry;
            Versionnumber = versionnumber;
            Isproductoverridden = isproductoverridden;
            ExtendedamountBase = extendedamountBase;
            Invoiceispricelocked = invoiceispricelocked;
            this._productidValue = _productidValue;
            TaxBase = taxBase;
            this._uomidValue = _uomidValue;
            Extendedamount = extendedamount;
            Owningbusinessunit = owningbusinessunit;
            this._createdbyValue = _createdbyValue;
            VolumediscountamountBase = volumediscountamountBase;
            Lineitemnumber = lineitemnumber;
            Parentbundleid = parentbundleid;
            ManualdiscountamountBase = manualdiscountamountBase;
            ShiptoStateorprovince = shiptoStateorprovince;
            Baseamount = baseamount;
            Productassociationid = productassociationid;
            Actualdeliveryon = actualdeliveryon;
            PriceperunitBase = priceperunitBase;
            Iscopied = iscopied;
            Quantitybackordered = quantitybackordered;
            Manualdiscountamount = manualdiscountamount;
            Invoicedetailid = invoicedetailid;
            Owninguser = owninguser;
            ShiptoCity = shiptoCity;
            Invoicestatecode = invoicestatecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Description = description;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            Modifiedon = modifiedon;
            ShiptoName = shiptoName;
            Createdon = createdon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            Importsequencenumber = importsequencenumber;
            Producttypecode = producttypecode;
            Overriddencreatedon = overriddencreatedon;
            ShiptoLine2 = shiptoLine2;
            Pricingerrorcode = pricingerrorcode;
            Shippingtrackingnumber = shippingtrackingnumber;
            ShiptoPostalcode = shiptoPostalcode;
            Willcall = willcall;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Productdescription = productdescription;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            ShiptoLine1 = shiptoLine1;
            ShiptoLine3 = shiptoLine3;
            this._invoiceidValue = _invoiceidValue;
            Tax = tax;
            BaseamountBase = baseamountBase;
            this._modifiedbyValue = _modifiedbyValue;
            Quantitycancelled = quantitycancelled;
            Exchangerate = exchangerate;
            Quantityshipped = quantityshipped;
            this._owneridValue = _owneridValue;
            Quantity = quantity;
            ShiptoFax = shiptoFax;
            ProductassociationidProductassociation = productassociationidProductassociation;
            Modifiedby = modifiedby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            InvoiceDetailBulkDeleteFailures = invoiceDetailBulkDeleteFailures;
            Uomid = uomid;
            Salesrepid = salesrepid;
            Productid = productid;
            InvoiceDetailDynamicpropertyinstance = invoiceDetailDynamicpropertyinstance;
            InvoiceDetailSyncErrors = invoiceDetailSyncErrors;
            InvoiceDetailAsyncOperations = invoiceDetailAsyncOperations;
            Invoiceid = invoiceid;
            ParentbundleidInvoicedetail = parentbundleidInvoicedetail;
            InvoicedetailParentInvoicedetail = invoicedetailParentInvoicedetail;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public object Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesrepid_value")]
        public string _salesrepidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public object Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public object ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceispricelocked")]
        public bool? Invoiceispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public object TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public object Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public object VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public object ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public object Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualdeliveryon")]
        public System.DateTimeOffset? Actualdeliveryon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public object PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscopied")]
        public bool? Iscopied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitybackordered")]
        public object Quantitybackordered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public object Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetailid")]
        public string Invoicedetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicestatecode")]
        public int? Invoicestatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingtrackingnumber")]
        public string Shippingtrackingnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_invoiceid_value")]
        public string _invoiceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public object Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public object BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitycancelled")]
        public object Quantitycancelled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityshipped")]
        public object Quantityshipped { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public object Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> InvoiceDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesrepid")]
        public MicrosoftDynamicsCRMsystemuser Salesrepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> InvoiceDetailDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> InvoiceDetailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> InvoiceDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceid")]
        public MicrosoftDynamicsCRMinvoice Invoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail ParentbundleidInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicedetail_parent_invoicedetail")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> InvoicedetailParentInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
