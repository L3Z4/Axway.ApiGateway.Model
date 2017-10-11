namespace Axway.ApiGateway.Model
{
    /// <summary>OAuth Application Scope</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OAuthAppScope
    {
        /// <summary>The unique identifier for the oauth protected resource</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The unique identifier for the application that has this scope</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>The scope string</summary>
        [Newtonsoft.Json.JsonProperty("scope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>Flag to indicate if this scope is one of the applications default scopes</summary>
        [Newtonsoft.Json.JsonProperty("isDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OAuthAppScope FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OAuthAppScope>(data);
        }
    }
}