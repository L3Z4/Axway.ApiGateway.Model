namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager external client</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ExternalClient
    {
        /// <summary>The ID of the external client</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The 3rd party client ID. This client ID is provided by a 3rd party OAuth service and is used to map an application to an external client. This value is unique, i.e. no other application can specify the same client ID.</summary>
        [Newtonsoft.Json.JsonProperty("clientId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>Flag disables the external client so it can't be used in authentication</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        /// <summary>The unique identifier of the user that created the mapping</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>Epoch/Unix time stamp when the mapping was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>The domains to allow access for browser-based clients</summary>
        [Newtonsoft.Json.JsonProperty("corsOrigins", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> CorsOrigins { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ExternalClient FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExternalClient>(data);
        }
    }
}