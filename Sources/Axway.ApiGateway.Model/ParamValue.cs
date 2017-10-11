namespace Axway.ApiGateway.Model
{
    /// <summary>Outbound parameter value.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ParamValue
    {
        /// <summary>The parameter name.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The type of parameter type.  Can be one of: *body*, *query*, *path*, *form*, or *header*.</summary>
        [Newtonsoft.Json.JsonProperty("paramType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParamType { get; set; }

        /// <summary>The parameter data type.  Can be one of: *string*, *integer*, etc.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>The parameter value.  Can be a regular value, or a selector, e.g.: ${params.path.id}.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>Indicates whether or not the parameter is required for the backend API.</summary>
        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Required { get; set; } = false;

        /// <summary>Indicates whether or not the parameter is excluded for the backend API.</summary>
        [Newtonsoft.Json.JsonProperty("exclude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Exclude { get; set; } = false;

        /// <summary>Indicates whether or not the parameter is an additional parameter (does not replace an existing parameter).</summary>
        [Newtonsoft.Json.JsonProperty("additional", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Additional { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ParamValue FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ParamValue>(data);
        }
    }
}