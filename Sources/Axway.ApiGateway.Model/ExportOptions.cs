namespace Axway.ApiGateway.Model
{
    /// <summary>Options available on export of applications</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ExportOptions
    {
        /// <summary>If specified, the name of the file that the exported applications will be wrote to</summary>
        [Newtonsoft.Json.JsonProperty("filename", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Filename { get; set; }

        /// <summary>Password value which, when specified, will be use to encrypt the output stream for the export</summary>
        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>List of the application ids that was chosen for export</summary>
        [Newtonsoft.Json.JsonProperty("appIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> AppIds { get; set; }

        /// <summary>Flag to indicate if api quota information is to be included in the export</summary>
        [Newtonsoft.Json.JsonProperty("quota", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Quota { get; set; } = false;

        /// <summary>Flag to indicate if oauth credentials are to be included in the export</summary>
        [Newtonsoft.Json.JsonProperty("oauth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Oauth { get; set; } = false;

        /// <summary>Flag to indicate if api keys are to be included in the export</summary>
        [Newtonsoft.Json.JsonProperty("apikeys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Apikeys { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ExportOptions FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExportOptions>(data);
        }
    }
}