namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager API Key for use in authenticating applications</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class APIKey
    {
        /// <summary>The API Key ID which is used to identify applications. You include it in each request, so it's not a secret.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The API Key ID which is used to identify applications. You include it in each request, so it's not a secret.</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>Each  API Key ID has a Secret Key associated with it. This key is just a long string of characters that can be used to calculate the digital signature that can be included in requests. Your Secret Key is a secret do not distribute.</summary>
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>Flag disables the API key so can't be used in authentication</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        /// <summary>The unique identifier for user that generated the API Key</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>Epoch/Unix time stamp when the API key was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>Epoch/Unix time stamp when the API key was deleted</summary>
        [Newtonsoft.Json.JsonProperty("deletedOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? DeletedOn { get; set; }

        /// <summary>The domains to allow access for browser-based clients</summary>
        [Newtonsoft.Json.JsonProperty("corsOrigins", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> CorsOrigins { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static APIKey FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<APIKey>(data);
        }
    }
}