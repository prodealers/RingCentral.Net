namespace RingCentral
{
    // Query parameters for operation listExtensionActiveCalls
    public class ListExtensionActiveCallsParameters
    {
        /// <summary>
        /// The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
        /// Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        /// View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        /// Default: Simple
        /// Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        /// Call type of a record. If not specified, all call types are returned. Multiple values are accepted
        /// Enum: Voice, Fax
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are allowed
        /// Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}