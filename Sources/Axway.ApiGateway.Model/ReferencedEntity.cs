namespace Axway.ApiGateway.Model
{
    /// <summary>Referenced entity.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ReferencedEntity
    {
        /// <summary>Name of the referenced entity (as specified in Policy Studio configuration).</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Portable version of the ESPK of this referenced entity, formatted as an XML fragment.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ReferencedEntity FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ReferencedEntity>(data);
        }
    }
}