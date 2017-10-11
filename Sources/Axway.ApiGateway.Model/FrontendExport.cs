namespace Axway.ApiGateway.Model
{
    /// <summary>Frontend API export definition.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FrontendExport
    {
        /// <summary>List of frontend API</summary>
        [Newtonsoft.Json.JsonProperty("apis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<VirtualizedAPI> Apis { get; set; }

        /// <summary>List of frontend API methods</summary>
        [Newtonsoft.Json.JsonProperty("methods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<VirtualizedMethodExport> Methods { get; set; }

        /// <summary>List of backend API methods</summary>
        [Newtonsoft.Json.JsonProperty("backendMethods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<BackendMethodExport> BackendMethods { get; set; }

        /// <summary>Image Export</summary>
        [Newtonsoft.Json.JsonProperty("imagedata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> Imagedata { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static FrontendExport FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FrontendExport>(data);
        }
    }
}