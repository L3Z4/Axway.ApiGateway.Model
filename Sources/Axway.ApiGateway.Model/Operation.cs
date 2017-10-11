namespace Axway.ApiGateway.Model
{
    /// <summary>An operation available to an API path.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Operation
    {
        /// <summary>An identifier</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>Shema title</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>Description about the Schema</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The format ex: int32, int64, float, double, byte, binary, date, date-time or password</summary>
        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>Specifies if the paramater is required</summary>
        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Required { get; set; }

        /// <summary>Not used beacause our model does not support inline nested types</summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, SchemaObject> Properties { get; set; }

        /// <summary>if the schema is an array specifies the items type</summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SchemaObject Items { get; set; }

        /// <summary>if the schema is an array specifies the items type</summary>
        [Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Example { get; set; }

        [Newtonsoft.Json.JsonProperty("discriminator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Discriminator { get; set; }

        /// <summary>The HTTP method</summary>
        [Newtonsoft.Json.JsonProperty("httpMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HttpMethod { get; set; }

        /// <summary>The nickname of the operation</summary>
        [Newtonsoft.Json.JsonProperty("nickname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>A short summary description of the operation</summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>A detailed description of the operation</summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>The return type of the method, e.g. void, array, or a type found in models</summary>
        [Newtonsoft.Json.JsonProperty("responseClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponseClass { get; set; }

        /// <summary>A list of possible response messages and their meanings</summary>
        [Newtonsoft.Json.JsonProperty("errorResponses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ErrorResponse> ErrorResponses { get; set; }

        /// <summary>The content types that the operation consumes</summary>
        [Newtonsoft.Json.JsonProperty("consumes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Consumes { get; set; }

        /// <summary>The content types that the operation produces</summary>
        [Newtonsoft.Json.JsonProperty("produces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Produces { get; set; }

        /// <summary>Authorizations</summary>
        [Newtonsoft.Json.JsonProperty("authorizations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<object>> Authorizations { get; set; }

        /// <summary>The list of tags associated with this API operation. Each tag can have multiple values</summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> Tags { get; set; }

        /// <summary>The security profile associated with the API Method. This profile will override the profile associated with the API</summary>
        [Newtonsoft.Json.JsonProperty("securityProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SwaggerSecurityProfile SecurityProfile { get; set; }

        /// <summary>The documentation URL for the operation</summary>
        [Newtonsoft.Json.JsonProperty("documentationUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DocumentationUrl { get; set; }

        /// <summary>Indicates that the API is CORS enabled</summary>
        [Newtonsoft.Json.JsonProperty("cors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Cors { get; set; } = false;

        /// <summary>A list of accepted parameters</summary>
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Parameter> Parameters { get; set; }

        /// <summary>A Reference to a definition on defitions object</summary>
        [Newtonsoft.Json.JsonProperty("__referencePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string __referencePath { get; set; }

        /// <summary>Default value for this schema if it is applicable</summary>
        [Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Default { get; set; }

        /// <summary>The return type of the method, e.g. void, array, or a type found in models</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Operation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Operation>(data);
        }
    }
}