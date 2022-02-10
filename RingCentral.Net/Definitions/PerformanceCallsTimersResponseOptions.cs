namespace RingCentral
{
    /// <summary>
    ///     Performance calls timers. 'callsDurationByQueueSla' timer is only applicable to Queues grouping
    /// </summary>
    public class PerformanceCallsTimersResponseOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsTimer allCallsDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsSegmentsDuration { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByDirection { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByOrigin { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByResponse { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByType { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByResult { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByCompanyHours { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimer callsDurationByQueueSla { get; set; }
    }
}