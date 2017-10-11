namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager application.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Application
    {
        /// <summary>The unique identifier for the application</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The display name for the application</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Descriptive text for the application</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The organization identifier to which the application belongs</summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>Contact phone number of the application</summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>The contact email address associated with the application</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>The unique identifier for user that created the application</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>A list of unique identifier for users that manages the application</summary>
        [Newtonsoft.Json.JsonProperty("managedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> ManagedBy { get; set; }

        /// <summary>Epoch/Unix time stamp when the application was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>Flag to indicate if this application is enabled or not</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        /// <summary>URI of the image to be used for this application, this field only indicates that the application has an image assigned to it. In order to retrieve the actual image use the following URL /api/portal/applications/{id}/image/</summary>
        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>Flag to indicate if an application has been approved by the API Manager admin or if delegated then the org admin</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Application FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Application>(data);
        }
    }
}