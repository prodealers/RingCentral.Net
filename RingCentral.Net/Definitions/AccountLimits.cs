namespace RingCentral
{
    /// <summary>
    ///     Limits which are effective for the account
    /// </summary>
    public class AccountLimits
    {
        /// <summary>
        ///     Max number of free softphone phone lines per user extension
        /// </summary>
        public long? freeSoftPhoneLinesPerExtension { get; set; }

        /// <summary>
        ///     Max number of participants in RingCentral meeting hosted by this account's user
        /// </summary>
        public long? meetingSize { get; set; }

        /// <summary>
        ///     Meetings recording cloud storage limitation in Gb
        /// </summary>
        public long? cloudRecordingStorage { get; set; }

        /// <summary>
        ///     Max number of extensions which can be included in the list of users monitored for Presence
        /// </summary>
        public long? maxMonitoredExtensionsPerUser { get; set; }

        /// <summary>
        ///     Max length of extension numbers of an account; the supported value is up to 8 symbols, depends on account type
        /// </summary>
        public long? maxExtensionNumberLength { get; set; }

        /// <summary>
        ///     Length of a site code
        /// </summary>
        public long? siteCodeLength { get; set; }

        /// <summary>
        ///     Length of a short extension number
        /// </summary>
        public long? shortExtensionNumberLength { get; set; }
    }
}