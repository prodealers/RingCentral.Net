using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Photo : Serializable
    {
        // Enum: photo
        public string type; // Required
        public string value; // Required
    }
}