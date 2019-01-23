using Newtonsoft.Json;

namespace RingCentral
{
    public class UpdateMessageRequest : Serializable
    {
        // Read status of a message to be changed. Multiple values are accepted
        // Enum: Read, Unread
        public string readStatus;
    }
}