namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation createCustomUserGreeting
    /// </summary>
    public class CreateCustomUserGreetingParameters
    {
        /// <summary>
        ///     Specifies whether to apply an answering rule or not. If set to true then `answeringRule` parameter is mandatory. If
        ///     set to false, then the answering rule is not applied even if specified
        ///     Default: true
        /// </summary>
        public bool? apply { get; set; }
    }
}