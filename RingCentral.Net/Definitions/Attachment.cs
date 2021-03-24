namespace RingCentral
{
    // Attachment is a file to be uploaded
    public class Attachment
    {
        /// <summary>
        /// Filename with extension
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// Binary content of the file
        /// Required
        /// </summary>
        public byte[] content { get; set; }

        /// <summary>
        /// Content type of the file, such as "image/png"
        /// </summary>
        public string contentType { get; set; }
    }
}