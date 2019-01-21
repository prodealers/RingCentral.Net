using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class TemplateInfo : Serializable
    {
        // Link to a template
        public string uri;
        // Internal identifier of a template
        public string id;
        // Enum: UserSettings, CallHandling
        public string type;
        // Name of a template
        public string name;
        // Time of a template creation
        public string creationTime;
        // Time of the last template modification
        public string lastModifiedTime;
    }
}