using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipEveryoneInfo : Serializable
    {
        // Internal identifier of a chat
        public string id;
        // Type of a chat
        public string type;
        // Chat name
        public string name;
        // Chat description
        public string description;
        // Chat creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string creationTime;
        // Chat last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string lastModifiedTime;
    }
}