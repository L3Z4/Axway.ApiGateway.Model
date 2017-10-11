namespace Axway.ApiGateway.Model
{
    /// <summary>Trusted CA certificate</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CACert
    {
        /// <summary>Raw certificate data</summary>
        [Newtonsoft.Json.JsonProperty("certBlob", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CertBlob { get; set; }

        /// <summary>Name of the certificate</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Certificate alias</summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>Certificate subject</summary>
        [Newtonsoft.Json.JsonProperty("subject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>Certificate issuer</summary>
        [Newtonsoft.Json.JsonProperty("issuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>Version of the certificate</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <summary>Start date of the certificate</summary>
        [Newtonsoft.Json.JsonProperty("notValidBefore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NotValidBefore { get; set; }

        /// <summary>Expiry date of the certificate</summary>
        [Newtonsoft.Json.JsonProperty("notValidAfter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NotValidAfter { get; set; }

        /// <summary>The algorithm used to sign the certificate.</summary>
        [Newtonsoft.Json.JsonProperty("signatureAlgorithm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>SHA1 fingerprint.</summary>
        [Newtonsoft.Json.JsonProperty("sha1Fingerprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sha1Fingerprint { get; set; }

        /// <summary>MD5 fingerprint.</summary>
        [Newtonsoft.Json.JsonProperty("md5Fingerprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Md5Fingerprint { get; set; }

        /// <summary>Flag indicating whether or not the certificate is expired.</summary>
        [Newtonsoft.Json.JsonProperty("expired", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Expired { get; set; } = false;

        /// <summary>Flag indicating whether or not the certificate is valid yet.</summary>
        [Newtonsoft.Json.JsonProperty("notYetValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? NotYetValid { get; set; } = false;

        /// <summary>Flag indicating whether this certificate is used for inbound SSL connections when invoking the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("inbound", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Inbound { get; set; } = false;

        /// <summary>Flag indicating whether this certificate is used for outbound SSL connections when invoking the virtualized API.</summary>
        [Newtonsoft.Json.JsonProperty("outbound", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Outbound { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CACert FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CACert>(data);
        }
    }
}