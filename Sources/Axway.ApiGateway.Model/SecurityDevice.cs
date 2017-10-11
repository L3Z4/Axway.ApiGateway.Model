namespace Axway.ApiGateway.Model
{
    /// <summary>Inbound security device.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SecurityDevice
    {
        /// <summary>Unique name of the Security Device.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The Security device type.  Values are one of: *apiKey*, *awsHeader*, *awsQuery*, *basic*, *twoWaySSL*, *oauth*, or *passThrough*.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Specifies the orider in which this device will be invoked.</summary>
        [Newtonsoft.Json.JsonProperty("order", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Order { get; set; }

        /// <summary>List of device-specific properties.</summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> Properties { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SecurityDevice FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SecurityDevice>(data);
        }
    }
}