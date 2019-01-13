using Newtonsoft.Json;

namespace RingCentral
{
    public class MessageChanges : Serializable
    {
        // Message type
        public string type;
        // The number of new messages. Can be omitted if the value is zero
        public int? newCount;
        // The number of updated messages. Can be omitted if the value is zero
        public int? updatedCount;
    }
}