namespace Axway.ApiGateway.Model
{
    /// <summary>Inbound profiles</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class InboundProfiles
    {
        /// <summary>The name of the Security Profile to be used for this Virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("securityProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecurityProfile { get; set; }

        /// <summary>The name of the CORS Profile to be used for this Virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("corsProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CorsProfile { get; set; }

        /// <summary>Enables metrics monitoring for the API</summary>
        [Newtonsoft.Json.JsonProperty("monitorAPI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? MonitorAPI { get; set; } = false;

        /// <summary>Identifies the client for metrics monitoring</summary>
        [Newtonsoft.Json.JsonProperty("monitorSubject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MonitorSubject { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static InboundProfiles FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InboundProfiles>(data);
        }
    }
}