namespace RingCentral
{
    /// <summary>
    ///     Filtering calls by segment
    /// </summary>
    public class CallSegmentFilter
    {
        /// <summary>
        ///     Required
        ///     Enum: Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting
        /// </summary>
        public string callSegment { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCallSegmentLengthFilter callSegmentLength { get; set; }
    }
}