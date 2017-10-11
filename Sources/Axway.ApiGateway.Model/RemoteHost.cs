namespace Axway.ApiGateway.Model
{
    /// <summary>An API Manager-registered remote host.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.7.3.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RemoteHost
    {
        /// <summary>The unique identifier for the remote host</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The host name of the remote host</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>The host port of the remote host</summary>
        [Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>Epoch/Unix time stamp when the remote host was created</summary>
        [Newtonsoft.Json.JsonProperty("createdOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>The unique identifier for user that created the remote host</summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>The organization identifier to which the remote host belongs</summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>The maximum number of connections to open to a Remote Host. If the maximum number of connections has already been established, the API Gateway instance waits for a connection to drop or become idle before making another request. The default value is -1, meaning there is no limit</summary>
        [Newtonsoft.Json.JsonProperty("maxConnections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxConnections { get; set; }

        /// <summary>Enables the API Gateway to use HTTP 1.1 when connecting to the remote host. Default value is false, meaning HTTP 1.0 is used</summary>
        [Newtonsoft.Json.JsonProperty("allowHTTP11", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AllowHTTP11 { get; set; } = false;

        /// <summary>If this option is set, the API Gateway will include the Content-Length HTTP header in all requests to this Remote Host. Default value is false.</summary>
        [Newtonsoft.Json.JsonProperty("includeContentLengthRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeContentLengthRequest { get; set; } = false;

        /// <summary>If this option is set, if the API Gateway receives a response from this Remote Host that contains a Content-Length HTTP header, it returns this length to the client. Default value is false.</summary>
        [Newtonsoft.Json.JsonProperty("includeContentLengthResponse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeContentLengthResponse { get; set; } = false;

        /// <summary>Adds a field to outbound TLS/SSL calls that shows the name that the client used to connect. Default value is false.</summary>
        [Newtonsoft.Json.JsonProperty("offerTLSServerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OfferTLSServerName { get; set; } = false;

        /// <summary>Ensures that the certificate presented by the server matches the name of the remote host being connected to. This prevents host spoofing and man-in-the-middle attacks. Default value is false.</summary>
        [Newtonsoft.Json.JsonProperty("verifyServerHostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? VerifyServerHostname { get; set; } = false;

        /// <summary>If a connection to this remote host is not established within the time set in this field, the connection times out and the connection fails. Default value is 30000 milliseconds (30 seconds).</summary>
        [Newtonsoft.Json.JsonProperty("connectionTimeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ConnectionTimeout { get; set; }

        /// <summary>The maximum amount of time permitted between reading successive blocks of data. If the Active Timeout is exceeded, the API Gateway closes the connection. This prevents a Remote Host from closing the connection while sending data. Default value is 30000 milliseconds (30 seconds).</summary>
        [Newtonsoft.Json.JsonProperty("activeTimeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ActiveTimeout { get; set; }

        /// <summary>The maximum amount of time permitted to complete the transaction. Default value is 240000 milliseconds (4 minutes).</summary>
        [Newtonsoft.Json.JsonProperty("transactionTimeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TransactionTimeout { get; set; }

        /// <summary>The maximum amount of time that API Gateway waits after sending a message over a persistent connection to the Remote Host before it closes the connection. Default value is 15000 milliseconds (15 seconds).</summary>
        [Newtonsoft.Json.JsonProperty("idleTimeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? IdleTimeout { get; set; }

        /// <summary>The maximum amount of data the API Gateway can receive per transaction. Default value is 10485760 bytes (10Mb).</summary>
        [Newtonsoft.Json.JsonProperty("maxReceiveBytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MaxReceiveBytes { get; set; }

        /// <summary>The maximum amount of data the API Gateway can transmit per transaction. Default value is 10485760 bytes (10Mb).</summary>
        [Newtonsoft.Json.JsonProperty("maxSendBytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MaxSendBytes { get; set; }

        /// <summary>The maximum amount of memory allocated to each request. Default value is 8192 bytes.</summary>
        [Newtonsoft.Json.JsonProperty("inputBufferSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? InputBufferSize { get; set; }

        /// <summary>The maximum amount of memory allocated to each response. Default value is 8192 bytes.</summary>
        [Newtonsoft.Json.JsonProperty("outputBufferSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OutputBufferSize { get; set; }

        /// <summary>The period of time to cache addressing information after it has been received from the naming service. Default value is 300000 milliseconds (5 minutes)</summary>
        [Newtonsoft.Json.JsonProperty("addressCacheTimeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? AddressCacheTimeout { get; set; }

        /// <summary>Specifies the size of the SSL session cache for connections to the remote host, which controls the number of idle SSL sessions that can be kept in memory. Default value is 32.</summary>
        [Newtonsoft.Json.JsonProperty("sslSessionCacheSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SslSessionCacheSize { get; set; }

        /// <summary>Specifies the HTTP content encodings that the API Gateway can accept from peers. Supported encodings: *deflate*, *gzip*. If no encodings are specified the default encoding is applied.</summary>
        [Newtonsoft.Json.JsonProperty("inputEncodings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> InputEncodings { get; set; }

        /// <summary>Specifies the HTTP content encodings that the API Gateway can apply to outgoing messages. Supported encodings: *deflate*, *gzip*. If no encodings are specified the default encoding is applied.</summary>
        [Newtonsoft.Json.JsonProperty("outputEncodings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> OutputEncodings { get; set; }

        /// <summary>Specifies whether to add the X-CorrelationID header to outbound messages</summary>
        [Newtonsoft.Json.JsonProperty("exportCorrelationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ExportCorrelationId { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RemoteHost FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RemoteHost>(data);
        }
    }
}