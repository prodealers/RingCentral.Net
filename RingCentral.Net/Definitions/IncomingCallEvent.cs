namespace RingCentral
{
    public class IncomingCallEvent
    {
        /// <summary>
        /// </summary>
        public APSInfo aps { get; set; }

        /// <summary>
        ///     Event filter URI
        /// </summary>
        public string @event { get; set; }

        /// <summary>
        ///     Universally unique identifier of a notification
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription
        /// </summary>
        public string subscriptionId { get; set; }

        /// <summary>
        ///     The datetime of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for
        ///     example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        ///     Default: ~
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Calling action, for example 'StartRing'
        /// </summary>
        public string action { get; set; }

        /// <summary>
        ///     Identifier of a call session
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        ///     Identifier of a server
        /// </summary>
        public string serverId { get; set; }

        /// <summary>
        ///     Phone number of a caller. For GCM transport type '_from' property should be used
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Caller name
        /// </summary>
        public string fromName { get; set; }

        /// <summary>
        ///     Phone number of a callee
        /// </summary>
        public string to { get; set; }

        /// <summary>
        ///     Callee name
        /// </summary>
        public string toName { get; set; }

        /// <summary>
        ///     Unique identifier of a session
        /// </summary>
        public string sid { get; set; }

        /// <summary>
        ///     SIP proxy registration name
        /// </summary>
        public string toUrl { get; set; }

        /// <summary>
        ///     User data
        /// </summary>
        public string srvLvl { get; set; }

        /// <summary>
        ///     User data
        /// </summary>
        public string srvLvlExt { get; set; }

        /// <summary>
        ///     File containing recorded caller name
        /// </summary>
        public string recUrl { get; set; }

        /// <summary>
        ///     Notification lifetime value in seconds, the default value is 30 seconds
        /// </summary>
        public long? pn_ttl { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}