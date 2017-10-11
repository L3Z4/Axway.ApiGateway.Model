namespace Axway.ApiGateway.Model
{
    /// <summary>OAuth protected resource.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OAuthResource
    {
        /// <summary>The unique identifier for the oauth protected resource</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The unique identifier for the application who has access to this resource</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>The uri prefix which this oauth protected resource relates to</summary>
        [Newtonsoft.Json.JsonProperty("uriprefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Uriprefix { get; set; }

        /// <summary>Set of scope strings that have been resolved from querying the OAuth Resource Service at the uri prefix</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Scopes { get; set; }

        /// <summary>Flag to indicate if this oauth protected resource is enabled or not</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("isDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("scope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Scope { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OAuthResource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OAuthResource>(data);
        }
    }
}