namespace RingCentral
{
    /// <summary>
    ///     Operator's extension information. This extension will receive all calls and messages intended for the operator.
    /// </summary>
    public class AccountOperatorInfo
    {
        /// <summary>
        ///     Link to an operator extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an operator extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Number of an operator extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}