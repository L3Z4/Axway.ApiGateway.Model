namespace Axway.ApiGateway.Model
{
    /// <summary>A Swagger API definition.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Swagger
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

        /// <summary>The API version</summary>
        [Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>The Swagger version</summary>
        [Newtonsoft.Json.JsonProperty("swaggerVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SwaggerVersion { get; set; }

        /// <summary>The base path</summary>
        [Newtonsoft.Json.JsonProperty("basePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasePath { get; set; }

        /// <summary>The resource path hosted</summary>
        [Newtonsoft.Json.JsonProperty("resourcePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourcePath { get; set; }

        /// <summary>The models/schema for the API</summary>
        [Newtonsoft.Json.JsonProperty("models", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> Models { get; set; }

        /// <summary>The content types that the API consumes</summary>
        [Newtonsoft.Json.JsonProperty("consumes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Consumes { get; set; }

        /// <summary>The content types that the API produces</summary>
        [Newtonsoft.Json.JsonProperty("produces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Produces { get; set; }

        /// <summary>The Authorization schemes provided for this API</summary>
        [Newtonsoft.Json.JsonProperty("authorizations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, Authorization> Authorizations { get; set; }

        /// <summary>The name of the API</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Brief summary of the API.</summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>The security profile associated with the API</summary>
        [Newtonsoft.Json.JsonProperty("securityProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SwaggerSecurityProfile SecurityProfile { get; set; }

        /// <summary>Array of basePaths supported for this API/service, based on the configured ports</summary>
        [Newtonsoft.Json.JsonProperty("basePaths", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> BasePaths { get; set; }

        /// <summary>API image URL</summary>
        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>The state of the API.  Possible values: 'pending', 'unpublished', or 'published'.</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>Indicates that the API is CORS enabled</summary>
        [Newtonsoft.Json.JsonProperty("cors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Cors { get; set; } = false;

        /// <summary>Indicates that the API is expired.</summary>
        [Newtonsoft.Json.JsonProperty("expired", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Expired { get; set; } = false;

        /// <summary>Indicates that the API is deprecated.  If 'true', then the API may have a 'retirementDate'.</summary>
        [Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Deprecated { get; set; } = false;

        /// <summary>Indicates that the API is deprecated and will be retired on the supplied date (in milliseconds).</summary>
        [Newtonsoft.Json.JsonProperty("retirementDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RetirementDate { get; set; }

        /// <summary>The list of tags associated with this API. Each tag can have multiple values</summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> Tags { get; set; }

        /// <summary>The documentation URL for the operation</summary>
        [Newtonsoft.Json.JsonProperty("documentationUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DocumentationUrl { get; set; }

        /// <summary>The schema definitions that this API supports and links to those definitions.</summary>
        [Newtonsoft.Json.JsonProperty("availableApiDefinitions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> AvailableApiDefinitions { get; set; }

        /// <summary>The SDK downloads that this API supports and links to those downloads.</summary>
        [Newtonsoft.Json.JsonProperty("availableSDK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> AvailableSDK { get; set; }

        /// <summary>The API resources</summary>
        [Newtonsoft.Json.JsonProperty("apis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<API> Apis { get; set; }

        /// <summary>A Reference to a definition on defitions object</summary>
        [Newtonsoft.Json.JsonProperty("__referencePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string __referencePath { get; set; }

        /// <summary>Default value for this schema if it is applicable</summary>
        [Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Default { get; set; }

        /// <summary>The resource type. Possible values: 'rest', 'wsdl'</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Swagger FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Swagger>(data);
        }
    }
}