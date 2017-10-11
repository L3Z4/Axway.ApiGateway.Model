namespace Axway.ApiGateway.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AuthenticatedUserAttributes
    {
        [Newtonsoft.Json.JsonProperty("firstLogin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FirstLogin { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("isSSOLogin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsSSOLogin { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("userDn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserDn { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AuthenticatedUserAttributes FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AuthenticatedUserAttributes>(data);
        }
    }
}