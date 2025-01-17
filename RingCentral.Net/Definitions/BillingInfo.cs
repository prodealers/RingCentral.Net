namespace RingCentral
{
    /// <summary>
    ///     Billing information related to the call. Returned for 'Detailed' view only
    /// </summary>
    public class BillingInfo
    {
        /// <summary>
        ///     Cost per minute, paid and already included in your RingCentral Plan. For example International Calls
        /// </summary>
        public decimal? costIncluded { get; set; }

        /// <summary>
        ///     Cost per minute, paid and not included in your RingCentral Plan
        /// </summary>
        public decimal? costPurchased { get; set; }
    }
}