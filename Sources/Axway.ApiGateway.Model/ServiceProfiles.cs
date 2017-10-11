namespace Axway.ApiGateway.Model
{
    /// <summary>Service profile configuration for backend services</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ServiceProfiles
    {
        /// <summary>The backend service API identifier</summary>
        [Newtonsoft.Json.JsonProperty("apiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>The backend service base path URL</summary>
        [Newtonsoft.Json.JsonProperty("basePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ServiceProfiles FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ServiceProfiles>(data);
        }
    }
}