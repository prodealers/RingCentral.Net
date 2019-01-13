using Newtonsoft.Json;

namespace RingCentral
{
    public class CompanyAnsweringRuleInfo : Serializable
    {
        // Internal identifier of an answering rule
        public string id;
        // Canonical URI of an answering rule
        public string uri;
        // Specifies if the rule is active or inactive. The default value is 'True'
        public bool? enabled;
        // Type of an answering rule
        public string type;
        // Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where 'N' is the first free number
        public string name;
        // Answering rule will be applied when calls are received from the specified caller(s)
        public CompanyAnsweringRuleCallersInfoRequest[] callers;
        // Answering rule will be applied when calling the specified number(s)
        public CompanyAnsweringRuleCalledNumberInfoRequest[] calledNumbers;
        // Schedule when an answering rule should be applied ,
        public CompanyAnsweringRuleScheduleInfo schedule;
        // Specifies how incoming calls are forwarded. The default value is 'Operator' 'Operator' - play company greeting and forward to operator extension 'Disconnect' - play company greeting and disconnect 'Bypass' - bypass greeting to go to selected extension = ['Operator', 'Disconnect', 'Bypass']
        public string callHandlingAction;
        // Extension to which the call is forwarded in 'Bypass' mode
        public CompanyAnsweringRuleCallersInfoRequest extension;
        // Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        public GreetingInfo[] greetings;
    }
}