namespace Axway.ApiGateway.Model
{
    /// <summary>A metric time series.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Series
    {
        /// <summary>The metric type name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The amount of time, in milliseconds, between data points</summary>
        [Newtonsoft.Json.JsonProperty("pointInterval", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PointInterval { get; set; }

        /// <summary>The time of the first data point in milliseconds</summary>
        [Newtonsoft.Json.JsonProperty("pointStart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PointStart { get; set; }

        /// <summary>The a metric measurement at a specific time interval</summary>
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<double> Data { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Series FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Series>(data);
        }
    }
}