namespace Axway.ApiGateway.Model
{
    /// <summary>Backend API method export.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class BackendMethodExport
    {
        /// <summary>Internal use only.</summary>
        [Newtonsoft.Json.JsonProperty("apiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>Internal use only.</summary>
        [Newtonsoft.Json.JsonProperty("apiMethodId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiMethodId { get; set; }

        /// <summary>Internal use only.</summary>
        [Newtonsoft.Json.JsonProperty("op", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Op { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BackendMethodExport FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BackendMethodExport>(data);
        }
    }
}