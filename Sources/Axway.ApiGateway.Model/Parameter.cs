namespace Axway.ApiGateway.Model
{
    /// <summary>An API operation parameter for a [Method](Method.html), as part of the  [APIDefinition](APIDefinition.html).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Parameter
    {
        /// <summary>The parameter name.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The parameter data type, e.g. *boolean*, *byte*, *date*, *double*, *float*, *integer*, *long*, *string*, or a type name found in [APIDefinition models](APIDefinition.html#models).</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Format { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>Indicates that the parameter is required</summary>
        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Required { get; set; } = false;

        /// <summary>Indicates that the parameter can be included multiple times (e.g. query or form)</summary>
        [Newtonsoft.Json.JsonProperty("allowMultiple", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AllowMultiple { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SchemaObject Items { get; set; }

        /// <summary>Provides a default value for the parameter</summary>
        [Newtonsoft.Json.JsonProperty("defaultValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>The response schema</summary>
        [Newtonsoft.Json.JsonProperty("schema", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SchemaObject Schema { get; set; }

        /// <summary>The parameter type, e.g. query, form, path, body, header</summary>
        [Newtonsoft.Json.JsonProperty("paramType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParamType { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Parameter FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Parameter>(data);
        }
    }
}