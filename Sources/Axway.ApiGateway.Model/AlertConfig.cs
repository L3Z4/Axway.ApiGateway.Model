namespace Axway.ApiGateway.Model
{
    /// <summary>API alert system configuration</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AlertConfig
    {
        [Newtonsoft.Json.JsonProperty("runSysquotaExceeded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RunSysquotaExceeded { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("runSysquotaWarning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RunSysquotaWarning { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("runAppquotaExceeded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RunAppquotaExceeded { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("runAppquotaWarning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RunAppquotaWarning { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("quotaOverrideChanged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? QuotaOverrideChanged { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("quotaOverrideDeleted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? QuotaOverrideDeleted { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("quotaDefaultChanged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? QuotaDefaultChanged { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("quotaSystemChanged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? QuotaSystemChanged { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationCreate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationCreate { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationDelete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationDelete { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationEnable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationEnable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationDisable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationDisable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationAddapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationAddapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationRemoveapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationRemoveapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationEnableapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationEnableapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("organizationDisableapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OrganizationDisableapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("appdevRegister", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AppdevRegister { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("appdevApprove", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AppdevApprove { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("appdevDelete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AppdevDelete { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("appdevEnable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AppdevEnable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("appdevDisable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AppdevDisable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("appdevResetpwd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AppdevResetpwd { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationRegister", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationRegister { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationApprove", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationApprove { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationDelete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationDelete { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationEnable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationEnable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationDisable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationDisable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationRequestapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationRequestapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationApproveapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationApproveapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationRemoveapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationRemoveapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationEnableapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationEnableapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("applicationDisableapi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApplicationDisableapi { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apicatalogEnable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApicatalogEnable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apicatalogDisable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApicatalogDisable { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apiproxyPublish", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApiproxyPublish { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apiproxyDeprecate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApiproxyDeprecate { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apiproxyUndeprecate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApiproxyUndeprecate { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apiproxyRetire", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApiproxyRetire { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("apiproxyUnpublish", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ApiproxyUnpublish { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AlertConfig FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AlertConfig>(data);
        }
    }
}