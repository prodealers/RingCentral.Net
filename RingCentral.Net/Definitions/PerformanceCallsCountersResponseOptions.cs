namespace RingCentral
{
    /// <summary>
    ///     Performance calls counters
    /// </summary>
    public class PerformanceCallsCountersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsCounter allCalls { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByType { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsBySegments { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByActions { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByCompanyHours { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounter callsByQueueSla { get; set; }
    }
}