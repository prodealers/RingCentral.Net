using Newtonsoft.Json;

namespace RingCentral
{
    public class GetRingOutStatusResponseIntId : Serializable
    {
        // Internal identifier of a RingOut call
        public int? id;
        public string uri;
        // RingOut status information
        public RingOutStatusInfo status;
    }
}