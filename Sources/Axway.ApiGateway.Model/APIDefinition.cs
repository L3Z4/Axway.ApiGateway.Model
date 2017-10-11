namespace Axway.ApiGateway.Model
{
    /// <summary>An API definition.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class APIDefinition
    {
        /// <summary>A unique identifier.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The name of the API.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>A summary of the API.</summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>A detailed description of the API.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The API version.</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>The base path is where the API service is hosted.</summary>
        [Newtonsoft.Json.JsonProperty("basePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasePath { get; set; }

        /// <summary>The resource path is applied to **basePath** to provide the prefix for all API methods.</summary>
        [Newtonsoft.Json.JsonProperty("resourcePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourcePath { get; set; }

        /// <summary>The models/schema the that the API</summary>
        [Newtonsoft.Json.JsonProperty("models", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> Models { get; set; }

        /// <summary>The content types that the API consumes</summary>
        [Newtonsoft.Json.JsonProperty("consumes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Consumes { get; set; }

        /// <summary>The content types that the API produces</summary>
        [Newtonsoft.Json.JsonProperty("produces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Produces { get; set; }

        /// <summary>Indicates that the API definition is integral to a frontend API; that the API was imported to define the frontend API.</summary>
        [Newtonsoft.Json.JsonProperty("integral", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Integral { get; set; } = false;

        /// <summary>Epoch/Unix time stamp when the organization was created.</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>The identifier of the user that created the API.</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The [Organization](Organization.html) identifier.</summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>Indicates the type of service being imported. Possible values: rest, wsdl.</summary>
        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>Indicates whether or not an original definition is available</summary>
        [Newtonsoft.Json.JsonProperty("hasOriginalDefinition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HasOriginalDefinition { get; set; } = false;

        /// <summary>Specifies the URL used to import the backend API definition.</summary>
        [Newtonsoft.Json.JsonProperty("importUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImportUrl { get; set; }

        /// <summary>A list of properties associated with this API.</summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> Properties { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static APIDefinition FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<APIDefinition>(data);
        }
    }
}