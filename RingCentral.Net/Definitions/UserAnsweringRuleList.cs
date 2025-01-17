namespace RingCentral
{
    public class UserAnsweringRuleList
    {
        /// <summary>
        ///     Canonical URI of an answering rule list resource
        ///     Example: https://platform.ringcentral.com/restapi/v1.0/account/240913004/extension/240972004/answering-rule?page=1
        ///     &perPage=100
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of answering rules
        /// </summary>
        public UserAnsweringRuleListRecord[] records { get; set; }

        /// <summary>
        /// </summary>
        public UserAnsweringRuleListPaging paging { get; set; }

        /// <summary>
        /// </summary>
        public UserAnsweringRuleListNavigation navigation { get; set; }
    }
}