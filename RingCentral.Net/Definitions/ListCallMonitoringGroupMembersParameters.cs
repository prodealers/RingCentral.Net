namespace RingCentral
{
    // Query parameters for operation listCallMonitoringGroupMembers
    public class ListCallMonitoringGroupMembersParameters
    {
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