namespace Axway.ApiGateway.Model
{
    /// <summary>Represents a virtualized, frontend API.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class VirtualizedAPI
    {
        /// <summary>Unique ID of the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The organization that created the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>The identifier of the API that was virtualized.  This is the only attribute that is required to create a virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("apiId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiId { get; set; }

        /// <summary>The name of this virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The API version.</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>The virtual host of this virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("vhost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>The path that services this virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>Type of descripton to use.  One of: _manual_, _markdown_, _url_, or _original_ (default).</summary>
        [Newtonsoft.Json.JsonProperty("descriptionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionType { get; set; }

        /// <summary>Markdown string to use as the description of the API.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionManual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionManual { get; set; }

        /// <summary>Markdown file to use as the description of the API within the API Catalog.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionMarkdown", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionMarkdown { get; set; }

        /// <summary>External URL to use as the description of the API.</summary>
        [Newtonsoft.Json.JsonProperty("descriptionUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionUrl { get; set; }

        /// <summary>A short summary description of the API.</summary>
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>Immediately retires the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("retired", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Retired { get; set; } = false;

        /// <summary>Immediately expires the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("expired", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Expired { get; set; } = false;

        /// <summary>URI of the image to be used for this virtualized API. To update the image, please refer to the API.</summary>
        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>Date to retire the virtualized API.  If _retired_ is true, this is the date on which it was retired.</summary>
        [Newtonsoft.Json.JsonProperty("retirementDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RetirementDate { get; set; }

        /// <summary>Immediately deprecates the virtualized API.  If deprecated, then _retiredOn_ is optionally used to retire the virtualized API on the specified date.</summary>
        [Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Deprecated { get; set; } = false;

        /// <summary>The state of the virtualized API.  One of: unpublished, pending, or published.</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>Epoch/Unix time stamp when the virtualized API was created.</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>The unique identifier for user that created the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The suite of CORS Profiles for this virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("corsProfiles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CORSProfile> CorsProfiles { get; set; }

        /// <summary>The suite of Security Profiles for this virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("securityProfiles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<SecurityProfile> SecurityProfiles { get; set; }

        /// <summary>The suite of Security Profiles for this virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("authenticationProfiles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AuthenticationProfile> AuthenticationProfiles { get; set; }

        /// <summary>The inbound profiles that apply to the virtualized API.  There must always a *\_default* profile.</summary>
        [Newtonsoft.Json.JsonProperty("inboundProfiles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, InboundProfiles> InboundProfiles { get; set; }

        /// <summary>The outbound profiles that apply to the virtualized API.  There must always a *\_default* profile.</summary>
        [Newtonsoft.Json.JsonProperty("outboundProfiles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, OutboundProfiles> OutboundProfiles { get; set; }

        /// <summary>The inbound profiles that apply to the virtualized API.  There must always a *\_default* profile.</summary>
        [Newtonsoft.Json.JsonProperty("serviceProfiles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, ServiceProfiles> ServiceProfiles { get; set; }

        /// <summary>The outbound profiles that apply to the virtualized API.  There must always a *\_default* profile.</summary>
        [Newtonsoft.Json.JsonProperty("caCerts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CACert> CaCerts { get; set; }

        /// <summary>The list of tags associated with this API. Each tag can have multiple values</summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> Tags { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static VirtualizedAPI FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VirtualizedAPI>(data);
        }
    }
}