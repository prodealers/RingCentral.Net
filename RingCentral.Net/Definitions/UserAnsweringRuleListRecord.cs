namespace RingCentral
{
    public class UserAnsweringRuleListRecord
    {
        /// <summary>
        ///     Canonical URI to an answering rule resource
        ///     Example:
        ///     https://platform.ringcentral.com/restapi/v1.0/account/240913004/extension/240972004/answering-rule/business-hours-rule
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        ///     Example: business-hours-rule
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of an answering rule
        ///     Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Name of an answering rule specified by user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Specifies if an answering rule is active or inactive
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// </summary>
        public SharedLinesInfo sharedLines { get; set; }
    }
}