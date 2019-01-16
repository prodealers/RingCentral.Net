using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExportTaskResultInfo : Serializable
    {
        // Size of the collected data archive in bytes
        public long? size;
        // Canonical URI for downloading an archive
        public string uri;
    }
}