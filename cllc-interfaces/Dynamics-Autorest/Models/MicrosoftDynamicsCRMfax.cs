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
    /// fax
    /// </summary>
    public partial class MicrosoftDynamicsCRMfax
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMfax class.
        /// </summary>
        public MicrosoftDynamicsCRMfax()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMfax class.
        /// </summary>
        public MicrosoftDynamicsCRMfax(string subscriptionid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string faxnumber = default(string), int? importsequencenumber = default(int?), string category = default(string), string billingcode = default(string), bool? directioncode = default(bool?), int? numberofpages = default(int?), string coverpagename = default(string), string subcategory = default(string), string tsid = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementFax = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateFax = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingFax = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderFax = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordFax = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMbulkdeletefailure> faxBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMcampaignresponse> faxCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityFax = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMbusinessunit owningbusinessunitFax = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMaccount regardingobjectidAccountFax = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMannotation> faxAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMservice serviceidFax = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMactioncard> faxActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMsystemuser createdbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlead regardingobjectidLeadFax = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidFax = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMteam owningteamFax = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMduplicaterecord> faxDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleFax = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser owninguserFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaFaxSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMqueueitem> faxQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMactivityparty> faxActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMsystemuser modifiedbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMconnection> faxConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsla slainvokedidFaxSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityFax = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationFax = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceFax = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMcontact regardingobjectidContactFax = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceFax = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMquote regardingobjectidQuoteFax = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignFax = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMconnection> faxConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMcontract regardingobjectidContractFax = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMsyncerror> faxSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> faxDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderFax = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMincident regardingobjectidIncidentFax = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMasyncoperation> faxAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMadoxioAgencycommunication regardingobjectidAdoxioAgencycommunicationFax = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationFax = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioInvestigationstakeholder regardingobjectidAdoxioInvestigationstakeholderFax = default(MicrosoftDynamicsCRMadoxioInvestigationstakeholder), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesFax = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintFax = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationFax = default(MicrosoftDynamicsCRMadoxioInvestigation))
        {
            Subscriptionid = subscriptionid;
            Overriddencreatedon = overriddencreatedon;
            Faxnumber = faxnumber;
            Importsequencenumber = importsequencenumber;
            Category = category;
            Billingcode = billingcode;
            Directioncode = directioncode;
            Numberofpages = numberofpages;
            Coverpagename = coverpagename;
            Subcategory = subcategory;
            Tsid = tsid;
            RegardingobjectidEntitlementFax = regardingobjectidEntitlementFax;
            RegardingobjectidEntitlementtemplateFax = regardingobjectidEntitlementtemplateFax;
            RegardingobjectidBookableresourcebookingFax = regardingobjectidBookableresourcebookingFax;
            RegardingobjectidBookableresourcebookingheaderFax = regardingobjectidBookableresourcebookingheaderFax;
            RegardingobjectidKnowledgebaserecordFax = regardingobjectidKnowledgebaserecordFax;
            FaxBulkDeleteFailures = faxBulkDeleteFailures;
            FaxCampaignresponse = faxCampaignresponse;
            StageidProcessstage = stageidProcessstage;
            RegardingobjectidOpportunityFax = regardingobjectidOpportunityFax;
            OwningbusinessunitFax = owningbusinessunitFax;
            RegardingobjectidAccountFax = regardingobjectidAccountFax;
            FaxAnnotation = faxAnnotation;
            ServiceidFax = serviceidFax;
            FaxActioncard = faxActioncard;
            CreatedbyFax = createdbyFax;
            CreatedonbehalfbyFax = createdonbehalfbyFax;
            RegardingobjectidLeadFax = regardingobjectidLeadFax;
            TransactioncurrencyidFax = transactioncurrencyidFax;
            OwningteamFax = owningteamFax;
            FaxDuplicateMatchingRecord = faxDuplicateMatchingRecord;
            RegardingobjectidKnowledgearticleFax = regardingobjectidKnowledgearticleFax;
            OwninguserFax = owninguserFax;
            SlaFaxSla = slaFaxSla;
            FaxQueueItem = faxQueueItem;
            FaxActivityParties = faxActivityParties;
            ModifiedbyFax = modifiedbyFax;
            ModifiedonbehalfbyFax = modifiedonbehalfbyFax;
            ActivityidActivitypointer = activityidActivitypointer;
            FaxConnections2 = faxConnections2;
            SlainvokedidFaxSla = slainvokedidFaxSla;
            RegardingobjectidCampaignactivityFax = regardingobjectidCampaignactivityFax;
            RegardingobjectidBulkoperationFax = regardingobjectidBulkoperationFax;
            RegardingobjectidInvoiceFax = regardingobjectidInvoiceFax;
            RegardingobjectidContactFax = regardingobjectidContactFax;
            SlakpiinstanceFax = slakpiinstanceFax;
            RegardingobjectidQuoteFax = regardingobjectidQuoteFax;
            RegardingobjectidCampaignFax = regardingobjectidCampaignFax;
            FaxConnections1 = faxConnections1;
            RegardingobjectidContractFax = regardingobjectidContractFax;
            FaxSyncErrors = faxSyncErrors;
            FaxDuplicateBaseRecord = faxDuplicateBaseRecord;
            RegardingobjectidSalesorderFax = regardingobjectidSalesorderFax;
            RegardingobjectidIncidentFax = regardingobjectidIncidentFax;
            FaxAsyncOperations = faxAsyncOperations;
            RegardingobjectidAdoxioAgencycommunicationFax = regardingobjectidAdoxioAgencycommunicationFax;
            RegardingobjectidAdoxioApplicationFax = regardingobjectidAdoxioApplicationFax;
            RegardingobjectidAdoxioInvestigationstakeholderFax = regardingobjectidAdoxioInvestigationstakeholderFax;
            RegardingobjectidAdoxioLicencesFax = regardingobjectidAdoxioLicencesFax;
            RegardingobjectidAdoxioComplaintFax = regardingobjectidAdoxioComplaintFax;
            RegardingobjectidAdoxioInvestigationFax = regardingobjectidAdoxioInvestigationFax;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faxnumber")]
        public string Faxnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingcode")]
        public string Billingcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberofpages")]
        public int? Numberofpages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coverpagename")]
        public string Coverpagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tsid")]
        public string Tsid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_fax")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_fax")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_fax")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_fax")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_fax")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> FaxBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> FaxCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_fax")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_fax")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_fax")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> FaxAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_fax")]
        public MicrosoftDynamicsCRMservice ServiceidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> FaxActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_fax")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_fax")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_fax")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_fax")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_fax")]
        public MicrosoftDynamicsCRMteam OwningteamFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> FaxDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_fax")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_fax")]
        public MicrosoftDynamicsCRMsystemuser OwninguserFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_fax_sla")]
        public MicrosoftDynamicsCRMsla SlaFaxSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> FaxQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> FaxActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_fax")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_fax")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> FaxConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_fax_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidFaxSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_fax")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_fax")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_fax")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_fax")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_fax")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_fax")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_fax")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> FaxConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_fax")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FaxSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> FaxDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_fax")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_fax")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> FaxAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_agencycommunication_fax")]
        public MicrosoftDynamicsCRMadoxioAgencycommunication RegardingobjectidAdoxioAgencycommunicationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_fax")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigationstakeholder_fax")]
        public MicrosoftDynamicsCRMadoxioInvestigationstakeholder RegardingobjectidAdoxioInvestigationstakeholderFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_fax")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_fax")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_fax")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationFax { get; set; }

    }
}
