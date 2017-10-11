namespace Axway.ApiGateway.Model
{
    /// <summary>Organization Registration Token.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RegistrationToken
    {
        /// <summary>The registration code</summary>
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>Unique identifier for the organization who the registration code applies to</summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>Epoch/Unix time stamp when the registration code will expire</summary>
        [Newtonsoft.Json.JsonProperty("expiry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Expiry { get; set; }

        /// <summary>Epoch/Unix time stamp when the registration code was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>The unique identifier for user that create the registration code</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The remaining number of users that can use the registration code for self registration to an organization</summary>
        [Newtonsoft.Json.JsonProperty("userQuota", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? UserQuota { get; set; }

        /// <summary>The total number of users that can use the registration code for self registration to an organization since the code has been created</summary>
        [Newtonsoft.Json.JsonProperty("maxUsers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxUsers { get; set; }

        /// <summary>Flag disables registration code so that it can no longer be used for registration</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RegistrationToken FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RegistrationToken>(data);
        }
    }
}