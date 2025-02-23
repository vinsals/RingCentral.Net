namespace RingCentral
{
    public class ActiveCallInfoWithoutSIP
    {
        /// <summary>
        /// Internal identifier of a call
        /// </summary>
        public string id;

        /// <summary>
        /// Call direction
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Identifies if a call belongs to the call queue
        /// </summary>
        public bool? queueCall;

        /// <summary>
        /// Phone number or extension number of a caller. For GCM transport type '_from' property should be used
        /// </summary>
        public string from;

        /// <summary>
        /// Name of a caller
        /// </summary>
        public string fromName;

        /// <summary>
        /// Phone number or extension number of a callee
        /// </summary>
        public string to;

        /// <summary>
        /// Name of a callee
        /// </summary>
        public string toName;

        /// <summary>
        /// Internal identifier of a call party
        /// </summary>
        public string partyId;

        /// <summary>
        /// Time when the call is actually started
        /// </summary>
        public string startTime;

        /// <summary>
        /// Internal identifier of a call session
        /// </summary>
        public string sessionId;

        /// <summary>
        /// Telephony call status
        /// Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus;

        /// <summary>
        /// Telephony identifier of a call session
        /// </summary>
        public string telephonySessionId;

        /// <summary>
        /// Type of call termination. Supported for calls in 'NoCall' status. If the returned termination type is 'intermediate' it means the call is not actually ended, the connection is established on one of the devices
        /// Enum: final, intermediate
        /// </summary>
        public string terminationType;
    }
}