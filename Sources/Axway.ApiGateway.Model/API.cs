namespace Axway.ApiGateway.Model
{
    /// <summary>The API is a path and operations.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class API
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

        /// <summary>The API path</summary>
        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>The name of the REST API Method. This contains the exposed path.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The list of operations that can be performed on *path*</summary>
        [Newtonsoft.Json.JsonProperty("operations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Operation> Operations { get; set; }

        /// <summary>A Reference to a definition on defitions object</summary>
        [Newtonsoft.Json.JsonProperty("__referencePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string __referencePath { get; set; }

        /// <summary>Default value for this schema if it is applicable</summary>
        [Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Default { get; set; }

        /// <summary>The type ex: array , boolean, integer , null , number, object, string</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static API FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<API>(data);
        }
    }
}