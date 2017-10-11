namespace Axway.ApiGateway.Model
{
    /// <summary>Backend API export definition.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class BackendExport
    {
        /// <summary>List of backend API blobs</summary>
        [Newtonsoft.Json.JsonProperty("apiBlobs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<BackendBlob> ApiBlobs { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BackendExport FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BackendExport>(data);
        }
    }
}