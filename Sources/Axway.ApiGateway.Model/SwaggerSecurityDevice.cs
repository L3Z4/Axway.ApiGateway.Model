namespace Axway.ApiGateway.Model
{
    /// <summary>Security Device details.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SwaggerSecurityDevice
    {
        /// <summary>Type identifier for the device. Possible Values: HTTPBasicSecurityDevice, OAuthSecurityDevice, AWSRESTRequestSecurityDevice, AWSQueryStringRequestSecurityDevice, APIKeyOnlySecurityDevice, APIKeyAndSecretSecurityDevice, TwoWaySSLSecurityDevice</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Textual display name for the device</summary>
        [Newtonsoft.Json.JsonProperty("typeDisplayName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeDisplayName { get; set; }

        /// <summary>Name of the device</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Order of preference, zero being highest. Devices will attempt to authenticate the incoming request using this order of preference.</summary>
        [Newtonsoft.Json.JsonProperty("order", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Order { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SwaggerSecurityDevice FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SwaggerSecurityDevice>(data);
        }
    }
}