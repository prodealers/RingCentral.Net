namespace RingCentral
{
    // Query parameters for operation readA2PSMSOptOuts
    public class ReadA2PSMSOptOutsParameters
    {
        /// <summary>
        /// The sender's phone number (`from` field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages
        /// </summary>
        public string from { get; set; }

        /// <summary>
        /// The reciever's phone number (`to` field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages
        /// </summary>
        public string to { get; set; }

        /// <summary>
        /// Token of the page to be retrieved
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        /// Number of records to be returned for the page
        /// Default: 1000
        /// </summary>
        public long? perPage { get; set; }
    }
}