namespace Axway.ApiGateway.Model
{
    /// <summary>Inbound security profile.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SecurityProfile
    {
        /// <summary>Unique name of the Profile</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Indicates that this is the default profile.  There can be only one default.</summary>
        [Newtonsoft.Json.JsonProperty("isDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; } = false;

        /// <summary>List of SecurityDevice for this security profile</summary>
        [Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<SecurityDevice> Devices { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SecurityProfile FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SecurityProfile>(data);
        }
    }
}