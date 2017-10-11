namespace Axway.ApiGateway.Model
{
    /// <summary>CORS configuration profile.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CORSProfile
    {
        /// <summary>Unique name of the Profile</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Indicates that this is the default profile.  There can be only one default.</summary>
        [Newtonsoft.Json.JsonProperty("isDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; } = false;

        /// <summary>List of origins for this CORS Profile</summary>
        [Newtonsoft.Json.JsonProperty("origins", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Origins { get; set; }

        /// <summary>List of headers...</summary>
        [Newtonsoft.Json.JsonProperty("allowedHeaders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> AllowedHeaders { get; set; }

        /// <summary>List of headers...</summary>
        [Newtonsoft.Json.JsonProperty("exposedHeaders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> ExposedHeaders { get; set; }

        /// <summary>Specifies whether or credentials are supported for APIs/API Methods employing this CORS Profile.</summary>
        [Newtonsoft.Json.JsonProperty("supportCredentials", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SupportCredentials { get; set; } = false;

        /// <summary>Specifies the amount of time responses to OPTIONS requests are stored, in seconds, in the preflight result cache</summary>
        [Newtonsoft.Json.JsonProperty("maxAgeSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MaxAgeSeconds { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CORSProfile FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CORSProfile>(data);
        }
    }
}