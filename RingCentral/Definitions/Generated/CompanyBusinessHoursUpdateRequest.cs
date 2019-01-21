using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CompanyBusinessHoursUpdateRequest : Serializable
    {
        // Schedule when an answering rule is applied
        public CompanyBusinessHoursScheduleInfo schedule;
    }
}