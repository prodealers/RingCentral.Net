namespace RingCentral
{
    /// <summary>
    ///     Information on a calling/called party
    /// </summary>
    public class PartyInfo
    {
        /// <summary>
        ///     Phone number of a party
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Displayed name of a party
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Internal identifier of a device
        /// </summary>
        public string deviceId { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }
    }
}