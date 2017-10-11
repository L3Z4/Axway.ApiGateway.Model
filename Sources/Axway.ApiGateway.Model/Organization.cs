namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager organization</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Organization
    {
        /// <summary>The unique identifier for the organization</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The name of the organization</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The description of the organization</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The contact email address associated with the organization</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>URI of the image to be used for this organization. To update the image, please refer to the API.</summary>
        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>Indicates that the organization is restricted.  Users in a restricted organization cannot see other users, and users cannot register for the organization using tokens.  Default is 'false'.</summary>
        [Newtonsoft.Json.JsonProperty("restricted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Restricted { get; set; } = false;

        /// <summary>The virtual host associated with the organization</summary>
        [Newtonsoft.Json.JsonProperty("virtualHost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VirtualHost { get; set; }

        /// <summary>Contact phone number of the organization</summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>Flag to indicate if this organization is enabled or not</summary>
        [Newtonsoft.Json.JsonProperty("enabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } = false;

        /// <summary>Flag to indicate if this organization is enabled or not for API development.</summary>
        [Newtonsoft.Json.JsonProperty("development", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Development { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("dn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dn { get; set; }

        /// <summary>Epoch/Unix time stamp when the organization was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>Epoch/Unix time stamp when the trial starts</summary>
        [Newtonsoft.Json.JsonProperty("startTrialDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StartTrialDate { get; set; }

        /// <summary>Epoch/Unix time stamp when the trial expires</summary>
        [Newtonsoft.Json.JsonProperty("endTrialDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EndTrialDate { get; set; }

        /// <summary>Length of the trial in days</summary>
        [Newtonsoft.Json.JsonProperty("trialDuration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TrialDuration { get; set; }

        /// <summary>Indicates if this Org is a trial or not</summary>
        [Newtonsoft.Json.JsonProperty("isTrial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsTrial { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Organization FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Organization>(data);
        }
    }
}