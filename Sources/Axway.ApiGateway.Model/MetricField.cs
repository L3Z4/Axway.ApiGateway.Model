namespace Axway.ApiGateway.Model
{
    /// <summary>Queryable metric type information</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MetricField
    {
        /// <summary>The metric type name</summary>
        [Newtonsoft.Json.JsonProperty("metricType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetricType { get; set; }

        /// <summary>The metric aggregate name</summary>
        [Newtonsoft.Json.JsonProperty("aggregateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AggregateName { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MetricField FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MetricField>(data);
        }
    }
}