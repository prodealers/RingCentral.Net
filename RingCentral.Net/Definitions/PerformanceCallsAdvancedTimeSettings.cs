namespace RingCentral
{
    /// <summary>
    ///     Allows more granular control over time included in the report
    /// </summary>
    public class PerformanceCallsAdvancedTimeSettings
    {
        /// <summary>
        ///     IANA-compatible time zone name, for example 'America/Los_Angeles', 'Europe/Moscow'. See also *[Time
        ///     Zones](https://www.iana.org/time-zones)*
        /// </summary>
        public string timeZone { get; set; }

        /// <summary>
        ///     Days of the week for which the report is calculated
        ///     Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string[] includeDays { get; set; }

        /// <summary>
        ///     Hours of the day for which the report is calculated
        /// </summary>
        public PerformanceCallsTimeInterval[] includeHours { get; set; }
    }
}