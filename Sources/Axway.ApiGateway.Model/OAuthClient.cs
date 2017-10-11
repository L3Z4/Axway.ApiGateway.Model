namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager OAuth Credentials.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OAuthClient
    {
        /// <summary>The client ID to be used in OAuth flows</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The PEM encodeded certificate used in JWT flow</summary>
        [Newtonsoft.Json.JsonProperty("cert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cert { get; set; }

        /// <summary>The client application secret to be used in OAuth flows</summary>
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>OAuth defines two client types, based on their ability to authenticate securely with the authorization server. Possible values public or confidential</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Flag disables the OAuth credentials so they can't be used in authentication</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        /// <summary>The URL where the server will redirect the to present authorization codes or access tokens depending on the OAuth flow being executed</summary>
        [Newtonsoft.Json.JsonProperty("redirectUrls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> RedirectUrls { get; set; }

        /// <summary>The domains to allow access for browser-based clients</summary>
        [Newtonsoft.Json.JsonProperty("corsOrigins", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> CorsOrigins { get; set; }

        /// <summary>The unique identifier for user that generated the OAuth credentials</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>Epoch/Unix time stamp when the OAuth credentials was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>The application identifier associated with the OAuth credential</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OAuthClient FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OAuthClient>(data);
        }
    }
}