namespace Axway.ApiGateway.Model
{
    /// <summary>API Manager configuration</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Config
    {
        /// <summary>The name of the API Manager.</summary>
        [Newtonsoft.Json.JsonProperty("portalName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PortalName { get; set; }

        /// <summary>The network hostname or IP Address of the API Manager which will be used in email links.</summary>
        [Newtonsoft.Json.JsonProperty("portalHostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PortalHostname { get; set; }

        /// <summary>The name of the API Portal</summary>
        [Newtonsoft.Json.JsonProperty("apiPortalName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiPortalName { get; set; }

        /// <summary>The network hostname or IP Address of the API Portal which will be used in email links.</summary>
        [Newtonsoft.Json.JsonProperty("apiPortalHostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiPortalHostname { get; set; }

        /// <summary>Indicates if the API Portal is configured.</summary>
        [Newtonsoft.Json.JsonProperty("isApiPortalConfigured", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsApiPortalConfigured { get; set; } = false;

        /// <summary>Enables/disables user registration for the API Manager</summary>
        [Newtonsoft.Json.JsonProperty("registrationEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RegistrationEnabled { get; set; } = false;

        /// <summary>Enables/disables spport for resetting user passwords for the API Manager</summary>
        [Newtonsoft.Json.JsonProperty("resetPasswordEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ResetPasswordEnabled { get; set; } = false;

        /// <summary>The minimum password length.</summary>
        [Newtonsoft.Json.JsonProperty("minimumPasswordLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>Enables/disables auto-approve for user registration whereby API Administrator or Organization Administrator approval is not required.</summary>
        [Newtonsoft.Json.JsonProperty("autoApproveUserRegistration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AutoApproveUserRegistration { get; set; } = false;

        /// <summary>Enables/disables the ability to add System scopes to an Application. These scopes represent Gateway OAuth resources that are not covered by APIs.</summary>
        [Newtonsoft.Json.JsonProperty("systemOAuthScopesEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SystemOAuthScopesEnabled { get; set; } = false;

        /// <summary>Enables/disables auto-application approval whereby users do not need API Administrator or Organization Administrator approval.</summary>
        [Newtonsoft.Json.JsonProperty("autoApproveApplications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AutoApproveApplications { get; set; } = false;

        /// <summary>Enables/disables user administration to the Organization Administrators.</summary>
        [Newtonsoft.Json.JsonProperty("delegateUserAdministration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DelegateUserAdministration { get; set; } = false;

        /// <summary>Enables/disables application administration to the Organization Administrators.</summary>
        [Newtonsoft.Json.JsonProperty("delegateApplicationAdministration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DelegateApplicationAdministration { get; set; } = false;

        /// <summary>The network host and port that serves as the default virtual host from which API Manager registered API will be accessible through.</summary>
        [Newtonsoft.Json.JsonProperty("apiDefaultVirtualHost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApiDefaultVirtualHost { get; set; }

        /// <summary>The 'from' address used in emails.</summary>
        [Newtonsoft.Json.JsonProperty("emailFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailFrom { get; set; }

        /// <summary>An email address where undeliverable emails will be bounced to.</summary>
        [Newtonsoft.Json.JsonProperty("emailBounceAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailBounceAddress { get; set; }

        /// <summary>Enables/disables API promotion via policy.</summary>
        [Newtonsoft.Json.JsonProperty("promoteApiViaPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? PromoteApiViaPolicy { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("baseOAuth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? BaseOAuth { get; set; } = false;

        /// <summary>External user name</summary>
        [Newtonsoft.Json.JsonProperty("externalUserName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserName { get; set; }

        /// <summary>External user description</summary>
        [Newtonsoft.Json.JsonProperty("externalUserDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserDescription { get; set; }

        /// <summary>External user phone</summary>
        [Newtonsoft.Json.JsonProperty("externalUserPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserPhone { get; set; }

        /// <summary>External user email</summary>
        [Newtonsoft.Json.JsonProperty("externalUserEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserEmail { get; set; }

        /// <summary>External user organization name</summary>
        [Newtonsoft.Json.JsonProperty("externalUserOrganization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserOrganization { get; set; }

        /// <summary>External user role</summary>
        [Newtonsoft.Json.JsonProperty("externalUserRole", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserRole { get; set; }

        /// <summary>External user enabled</summary>
        [Newtonsoft.Json.JsonProperty("externalUserEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalUserEnabled { get; set; }

        /// <summary>Idle session timeout in milliseconds</summary>
        [Newtonsoft.Json.JsonProperty("sessionIdleTimeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SessionIdleTimeout { get; set; }

        /// <summary>Is trial enabled</summary>
        [Newtonsoft.Json.JsonProperty("isTrial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsTrial { get; set; } = false;

        /// <summary>Default trial duration in days</summary>
        [Newtonsoft.Json.JsonProperty("defaultTrialDuration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DefaultTrialDuration { get; set; }

        /// <summary>Login name validation regex</summary>
        [Newtonsoft.Json.JsonProperty("loginNameRegex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoginNameRegex { get; set; }

        /// <summary>The Version informaiton of API Manager.</summary>
        [Newtonsoft.Json.JsonProperty("productVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductVersion { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Config FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(data);
        }
    }
}