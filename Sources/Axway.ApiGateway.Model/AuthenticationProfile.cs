namespace Axway.ApiGateway.Model
{
    /// <summary>Outbound authentication profile.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AuthenticationProfile
    {
        /// <summary>Unique name of the Profile</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Indicates that this is the default profile.  There can be only one default.</summary>
        [Newtonsoft.Json.JsonProperty("isDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; } = false;

        /// <summary>Parameters for the backend authentication profile</summary>
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> Parameters { get; set; }

        /// <summary>Type of backend authentication. Possible values: *none*, *http_basic*, *apikey*, and *ssl*.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AuthenticationProfile FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AuthenticationProfile>(data);
        }
    }
}