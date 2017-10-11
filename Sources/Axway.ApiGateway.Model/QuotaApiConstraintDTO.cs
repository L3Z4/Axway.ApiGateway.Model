namespace Axway.ApiGateway.Model
{
    /// <summary>The APIConstraint is restriction that applies to API(s) and API method(s).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class QuotaApiConstraintDTO
    {
        /// <summary>The API identifier from API discovery, or '\*' for all API</summary>
        [Newtonsoft.Json.JsonProperty("api", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Api { get; set; }

        /// <summary>The API method identifier from API discovery, or '\*' for all methods</summary>
        [Newtonsoft.Json.JsonProperty("method", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>The restriction type, one of: throttle, throttlemb</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The restriction configuration</summary>
        [Newtonsoft.Json.JsonProperty("config", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> Config { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static QuotaApiConstraintDTO FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QuotaApiConstraintDTO>(data);
        }
    }
}