namespace RingCentral
{
    // Notification payload body
    public class TelephonySessionsEventBody
    {
        /// <summary>
        /// Order number of a notification to state the chronology
        /// </summary>
        public long? sequence;

        /// <summary>
        /// Legacy identifier of a call session
        /// </summary>
        public string sessionId;

        /// <summary>
        /// Call session identifier, required for Telephony API
        /// </summary>
        public string telephonySessionId;

        /// <summary>
        /// Identifier of a server
        /// </summary>
        public string serverId;

        /// <summary>
        /// The call start datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string eventTime;

        /// <summary>
        /// </summary>
        public OriginInfo origin;

        /// <summary>
        /// Call participants details
        /// </summary>
        public TelephonySessionsEventPartyInfo[] parties;
    }
}