namespace Axway.ApiGateway.Model
{
    /// <summary>A method available on an API resource.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Method
    {
        /// <summary>The method identifier</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The API identifier to which this method belongs</summary>
        [Newtonsoft.Json.JsonProperty("apiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>The API path</summary>
        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>The HTTP verb</summary>
        [Newtonsoft.Json.JsonProperty("verb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Verb { get; set; }

        /// <summary>The name of the operation</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>A short summary description of the operation</summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>A detailed description of the operation</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The return type of the method, e.g. void, array, or a type found in models</summary>
        [Newtonsoft.Json.JsonProperty("returnType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnType { get; set; }

        /// <summary>A list of accepted parameters</summary>
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Parameter> Parameters { get; set; }

        /// <summary>A list of possible response messages and their meanings</summary>
        [Newtonsoft.Json.JsonProperty("responseCodes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ResponseCode> ResponseCodes { get; set; }

        /// <summary>The content types that the operation consumes</summary>
        [Newtonsoft.Json.JsonProperty("consumes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Consumes { get; set; }

        /// <summary>The content types that the operation produces</summary>
        [Newtonsoft.Json.JsonProperty("produces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Produces { get; set; }

        /// <summary>A list of properties associated with this API Method. The list of properties may vary, depending on the type of the parent API.</summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> Properties { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Method FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Method>(data);
        }
    }
}