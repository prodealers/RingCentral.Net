namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation searchViaGet2
    /// </summary>
    public class SearchViaGet2Parameters
    {
        /// <summary>
        ///     only support 'userName' or 'email' filter expressions for now
        /// </summary>
        public string filter { get; set; }

        /// <summary>
        ///     start index (1-based)
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? startIndex { get; set; }

        /// <summary>
        ///     page size
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? count { get; set; }
    }
}