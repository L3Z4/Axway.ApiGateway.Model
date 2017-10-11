namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager system configuration</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SystemConfig
    {
        /// <summary>Returns a list of disabled APIs</summary>
        [Newtonsoft.Json.JsonProperty("disabledApis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> DisabledApis { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SystemConfig FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SystemConfig>(data);
        }
    }
}