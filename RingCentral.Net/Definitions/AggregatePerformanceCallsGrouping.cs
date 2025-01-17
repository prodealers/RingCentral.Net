namespace RingCentral
{
    /// <summary>
    ///     This field specifies the dimensions by which the response should be grouped and specific IDs to narrow the
    ///     response. If this field is **undefined or null**, the response will contain one record with data aggregated by the
    ///     whole company
    /// </summary>
    public class AggregatePerformanceCallsGrouping
    {
        /// <summary>
        ///     This field describes the dimensions by which the response should be grouped. See also *The [Developer
        ///     Guide](https://developers.ringcentral.com/guide/analytics/call-performance)*
        ///     Required
        ///     Enum: CompanyNumbers, Users, Queues, IVRs, SharedLines, UserGroups, Sites, Departments, DepartmentMembers,
        ///     UserGroupMembers, QueueAgents, SiteMembers
        /// </summary>
        public string groupBy { get; set; }

        /// <summary>
        ///     This field can be used to specify unique identifiers of groups in GroupBy types
        /// </summary>
        public string[] ids { get; set; }
    }
}