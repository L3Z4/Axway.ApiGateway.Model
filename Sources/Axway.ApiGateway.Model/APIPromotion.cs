namespace Axway.ApiGateway.Model
{
    /// <summary>API promotion package.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class APIPromotion
    {
        /// <summary>Frontend API export.</summary>
        [Newtonsoft.Json.JsonProperty("frontend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FrontendExport Frontend { get; set; }

        /// <summary>Backend API export.</summary>
        [Newtonsoft.Json.JsonProperty("backend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BackendExport Backend { get; set; }

        /// <summary>Export version</summary>
        [Newtonsoft.Json.JsonProperty("exportVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ExportVersion { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static APIPromotion FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<APIPromotion>(data);
        }
    }
}