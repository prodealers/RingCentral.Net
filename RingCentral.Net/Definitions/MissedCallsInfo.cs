namespace RingCentral
{
    public class MissedCallsInfo
    {
        /// <summary>
        ///     Email notification flag
        /// </summary>
        public bool? notifyByEmail { get; set; }

        /// <summary>
        ///     SMS notification flag
        /// </summary>
        public bool? notifyBySms { get; set; }

        /// <summary>
        ///     List of recipient email addresses for missed call notifications. Returned if specified, in both modes
        ///     (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedEmailAddresses { get; set; }

        /// <summary>
        ///     List of recipient phone numbers for missed call notifications. Returned if specified, in both modes
        ///     (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedSmsEmailAddresses { get; set; }
    }
}