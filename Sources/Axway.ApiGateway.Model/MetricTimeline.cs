namespace Axway.ApiGateway.Model
{
    /// <summary>The metrics timeline report is a report of a specific metric over a period of time.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MetricTimeline
    {
        /// <summary>The metric name.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The time series.</summary>
        [Newtonsoft.Json.JsonProperty("series", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Series> Series { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MetricTimeline FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MetricTimeline>(data);
        }
    }
}