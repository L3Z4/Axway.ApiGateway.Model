namespace Axway.ApiGateway.Model
{
    /// <summary>An OAuth Authorization</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Authorization
    {
        /// <summary>A list of scopes that a resource owner has authorized access to.</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Scopes { get; set; }

        /// <summary>The Date that the resource owner granted access to the scope(s).</summary>
        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Created { get; set; }

        /// <summary>The application requesting authorization.</summary>
        [Newtonsoft.Json.JsonProperty("applicationID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationID { get; set; }

        /// <summary>The unique identifier representing the resource owner who granted authorization to the client.</summary>
        [Newtonsoft.Json.JsonProperty("subject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>The unique identifier for the authorization</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Authorization FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Authorization>(data);
        }
    }
}