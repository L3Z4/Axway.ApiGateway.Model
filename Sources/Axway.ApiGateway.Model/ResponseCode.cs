namespace Axway.ApiGateway.Model
{
    /// <summary>An operation response code.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ResponseCode
    {
        /// <summary>The response code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Code { get; set; }

        /// <summary>The response message</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>The response schema</summary>
        [Newtonsoft.Json.JsonProperty("schema", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SchemaObject Schema { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ResponseCode FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseCode>(data);
        }
    }
}