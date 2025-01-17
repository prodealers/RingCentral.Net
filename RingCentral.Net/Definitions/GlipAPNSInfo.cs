namespace RingCentral
{
    /// <summary>
    ///     Apple notification data
    /// </summary>
    public class GlipAPNSInfo
    {
        /// <summary>
        /// </summary>
        public GlipAPSInfo aps { get; set; }

        /// <summary>
        ///     Datetime of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for
        ///     example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        ///     Universally unique identifier of a notification
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        ///     Event filter URI
        /// </summary>
        public string @event { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription
        /// </summary>
        public string subscriptionId { get; set; }

        /// <summary>
        /// </summary>
        public GlipUnreadMessageCountInfo body { get; set; }
    }
}