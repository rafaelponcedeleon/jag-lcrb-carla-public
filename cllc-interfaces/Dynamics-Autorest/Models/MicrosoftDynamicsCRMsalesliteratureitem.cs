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
    /// salesliteratureitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMsalesliteratureitem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesliteratureitem class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesliteratureitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesliteratureitem class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesliteratureitem(string _salesliteratureidValue = default(string), bool? iscustomerviewable = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), long? versionnumber = default(long?), string _modifiedbyValue = default(string), int? filetypecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string title = default(string), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string organizationid = default(string), string mimetype = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string authorname = default(string), string salesliteratureitemid = default(string), string abstractProperty = default(string), string keywords = default(string), string documentbody = default(string), object documentbodyBinary = default(object), string filename = default(string), string attacheddocumenturl = default(string), int? filesize = default(int?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesliterature salesliteratureid = default(MicrosoftDynamicsCRMsalesliterature), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> salesLiteratureItemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> salesLiteratureItemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            this._salesliteratureidValue = _salesliteratureidValue;
            Iscustomerviewable = iscustomerviewable;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Filetypecode = filetypecode;
            Modifiedon = modifiedon;
            Title = title;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Organizationid = organizationid;
            Mimetype = mimetype;
            Createdon = createdon;
            Authorname = authorname;
            Salesliteratureitemid = salesliteratureitemid;
            AbstractProperty = abstractProperty;
            Keywords = keywords;
            Documentbody = documentbody;
            DocumentbodyBinary = documentbodyBinary;
            Filename = filename;
            Attacheddocumenturl = attacheddocumenturl;
            Filesize = filesize;
            Importsequencenumber = importsequencenumber;
            Createdby = createdby;
            Salesliteratureid = salesliteratureid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            SalesLiteratureItemBulkDeleteFailures = salesLiteratureItemBulkDeleteFailures;
            Modifiedby = modifiedby;
            SalesLiteratureItemAsyncOperations = salesLiteratureItemAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesliteratureid_value")]
        public string _salesliteratureidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomerviewable")]
        public bool? Iscustomerviewable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filetypecode")]
        public int? Filetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorname")]
        public string Authorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitemid")]
        public string Salesliteratureitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abstract")]
        public string AbstractProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentbody")]
        public string Documentbody { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentbody_binary")]
        public object DocumentbodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attacheddocumenturl")]
        public string Attacheddocumenturl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureid")]
        public MicrosoftDynamicsCRMsalesliterature Salesliteratureid { get; set; }

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
        [JsonProperty(PropertyName = "SalesLiteratureItem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SalesLiteratureItemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SalesLiteratureItemAsyncOperations { get; set; }

    }
}
