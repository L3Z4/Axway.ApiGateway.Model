namespace Axway.ApiGateway.Model
{
    /// <summary>The Quota is a set of restrictions that apply to applications in the Portal.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class QuotaDTO
    {
        /// <summary>The quota identifier</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The quota type, either API or APPLICATION</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public QuotaDTOType? Type { get; set; }

        /// <summary>The name of the quota</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The quota for MyApplication the overrides default Application quota</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>An array of restrictions imposed on the quota</summary>
        [Newtonsoft.Json.JsonProperty("restrictions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<QuotaApiConstraintDTO> Restrictions { get; set; }

        /// <summary>Indicates if the quota is system (protected)</summary>
        [Newtonsoft.Json.JsonProperty("system", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? System { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static QuotaDTO FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<QuotaDTO>(data);
        }
    }
}