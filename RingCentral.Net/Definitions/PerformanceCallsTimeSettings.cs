namespace RingCentral
{
    /// <summary>
    ///     Date-time range for which the calls are aggregated. The call is considered to be within time range if it started
    ///     within time range. Both borders are inclusive
    /// </summary>
    public class PerformanceCallsTimeSettings
    {
        /// <summary>
        ///     Required
        /// </summary>
        public PerformanceCallsTimeRange timeRange { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsAdvancedTimeSettings advancedTimeSettings { get; set; }
    }
}