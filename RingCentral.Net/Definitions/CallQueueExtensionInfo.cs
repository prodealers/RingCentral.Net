namespace RingCentral
{
    /// <summary>
    ///     For Call Queue extension type only. Please note that legacy 'Department' extension type corresponds to 'Call Queue'
    ///     extensions in modern RingCentral product terminology
    /// </summary>
    public class CallQueueExtensionInfo
    {
        /// <summary>
        ///     Target percentage of calls that must be answered by agents within the service level time threshold
        /// </summary>
        public long? slaGoal { get; set; }

        /// <summary>
        ///     Period of time in seconds that is considered to be an acceptable service level
        /// </summary>
        public long? slaThresholdSeconds { get; set; }

        /// <summary>
        ///     If 'True' abandoned calls (hanged up prior to being served) are included into service level calculation
        /// </summary>
        public bool? includeAbandonedCalls { get; set; }

        /// <summary>
        ///     Period of time in seconds specifying abandoned calls duration - calls that are shorter will not be included into
        ///     the calculation of service level.; zero value means that abandoned calls of any duration will be included into
        ///     calculation
        /// </summary>
        public long? abandonedThresholdSeconds { get; set; }
    }
}