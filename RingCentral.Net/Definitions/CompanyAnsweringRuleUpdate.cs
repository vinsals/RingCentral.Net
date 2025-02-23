namespace RingCentral
{
    public class CompanyAnsweringRuleUpdate
    {
        /// <summary>
        /// Specifies if the rule is active or inactive. The default value is 'True'
        /// Default: true
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where 'N' is the first free number
        /// </summary>
        public string name;

        /// <summary>
        /// Answering rule will be applied when calls are received from the specified caller(s)
        /// </summary>
        public CompanyAnsweringRuleCallersInfoRequest[] callers;

        /// <summary>
        /// Answering rule will be applied when calling the specified number(s)
        /// </summary>
        public CompanyAnsweringRuleCalledNumberInfo[] calledNumbers;

        /// <summary>
        /// </summary>
        public CompanyAnsweringRuleScheduleInfoRequest schedule;

        /// <summary>
        /// Specifies how incoming calls are forwarded. The default value is 'Operator' 'Operator' - play company greeting and forward to operator extension 'Disconnect' - play company greeting and disconnect 'Bypass' - bypass greeting to go to selected extension = ['Operator', 'Disconnect','Bypass']
        /// Enum: Operator, Disconnect, Bypass
        /// </summary>
        public string callHandlingAction;

        /// <summary>
        /// Type of an answering rule
        /// Default: Custom
        /// Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type;

        /// <summary>
        /// Internal identifier of the extension the call is forwarded to. Supported for 'Bypass' mode only (that should be specified in `callHandlingAction` field)
        /// </summary>
        public string extension;

        /// <summary>
        /// Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        /// </summary>
        public GreetingInfo[] greetings;
    }
}