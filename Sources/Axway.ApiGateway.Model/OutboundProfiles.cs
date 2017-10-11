namespace Axway.ApiGateway.Model
{
    /// <summary>Outbound profiles</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OutboundProfiles
    {
        /// <summary>Outbound authentication credentials if __routeType__ is 'proxy'.  Can be null to indicate no credentials.</summary>
        [Newtonsoft.Json.JsonProperty("authenticationProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthenticationProfile { get; set; }

        /// <summary>The route type.  Values are either: 'proxy' or 'policy'.    Can be null and defaults to *proxy*.</summary>
        [Newtonsoft.Json.JsonProperty("routeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RouteType { get; set; }

        /// <summary>Request policy that applies to all outbound requests.  Can be null to indicate no policy.</summary>
        [Newtonsoft.Json.JsonProperty("requestPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestPolicy { get; set; }

        /// <summary>Response policy that applies to all responses from outbound requests.  Can be null to indicate no policy.</summary>
        [Newtonsoft.Json.JsonProperty("responsePolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsePolicy { get; set; }

        /// <summary>Route policy if the routeType is 'policy', in which case it must be a valid policy ID.  Can be null if __routeType__ is 'proxy'.</summary>
        [Newtonsoft.Json.JsonProperty("routePolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoutePolicy { get; set; }

        /// <summary>Route to a different API.  Can be null.  Ignored on the 'default' outbound profile.</summary>
        [Newtonsoft.Json.JsonProperty("apiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>Route to a different API method.  Can be null.  Ignored on the 'default' outbound profile.</summary>
        [Newtonsoft.Json.JsonProperty("apiMethodId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiMethodId { get; set; }

        /// <summary>A list of outbound parameters values - maps from frontend parameters to backend parameters.</summary>
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ParamValue> Parameters { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OutboundProfiles FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OutboundProfiles>(data);
        }
    }
}