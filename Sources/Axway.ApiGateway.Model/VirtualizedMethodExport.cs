namespace Axway.ApiGateway.Model
{
    /// <summary>Frontend API method export.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class VirtualizedMethodExport
    {
        /// <summary>Unique ID of the method.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The identifier of the [VirtualizedAPI](VirtualizedAPI.html).</summary>
        [Newtonsoft.Json.JsonProperty("virtualizedApiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VirtualizedApiId { get; set; }

        /// <summary>The virtualized method name.  This defaults to the original [APIDefinition](APIDefinition.html) method name.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The reference identifier for the original [APIDefinition](APIDefinition.html) that was virtualized.</summary>
        [Newtonsoft.Json.JsonProperty("apiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>The reference identifier for the original API [APIDefinition](APIDefinition.html) method that was virtualized.</summary>
        [Newtonsoft.Json.JsonProperty("apiMethodId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiMethodId { get; set; }

        /// <summary>A summary of the API Method.</summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>The source for the method's description.  One of: *original*, *manual*, *markdown*, or *url*.  Defaults to *original*.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionType { get; set; }

        /// <summary>Specifies a manual description, which can be markdown text.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionManual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionManual { get; set; }

        /// <summary>specifies a markdown file to use for description.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionMarkdown", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionMarkdown { get; set; }

        /// <summary>Specifies a URL to use instead of description text.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionUrl { get; set; }

        /// <summary>The list of tags associated with this API method. Each tag can have multiple values.</summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> Tags { get; set; }

        /// <summary>Internal use only.</summary>
        [Newtonsoft.Json.JsonProperty("op", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Op { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static VirtualizedMethodExport FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VirtualizedMethodExport>(data);
        }
    }
}