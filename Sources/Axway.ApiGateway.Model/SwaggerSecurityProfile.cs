namespace Axway.ApiGateway.Model
{
    /// <summary>Security Profile details.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SwaggerSecurityProfile
    {
        /// <summary>List of Security Devices associated with this profile</summary>
        [Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<SwaggerSecurityDevice> Devices { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SwaggerSecurityProfile FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SwaggerSecurityProfile>(data);
        }
    }
}