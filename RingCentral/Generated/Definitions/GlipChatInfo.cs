using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipChatInfo : Serializable
    {
        // Internal identifier of a chat
        public string id;
        // Type of a chat
        public string type;
        // For 'Team' chat type only. Team access level.
        public bool? @public;
        // For 'Team','Everyone' chats types only. Chat name.
        public string name;
        // For 'Team','Everyone' chats types only. Chat description.
        public string description;
        // For 'Team' chat type only. Team status.
        public string status;
        // Chat creation datetime in ISO 8601 format
        public string creationTime;
        // Chat last change datetime in ISO 8601 format
        public string lastModifiedTime;
    }
}