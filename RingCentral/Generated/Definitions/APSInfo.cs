using Newtonsoft.Json;

namespace RingCentral
{
    public class APSInfo : Serializable
    {
        // If the value is '1' then notification is turned on even if the application is in background
        [JsonProperty("content-available")]
        public int? contentAvailable;
    }
}