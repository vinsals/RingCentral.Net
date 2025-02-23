namespace RingCentral
{
    // Notification payload body
    public class ExtensionPresenceEventBody
    {
        /// <summary>
        /// Internal identifier of an extension. Optional parameter
        /// Default: ~
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Telephony presence status. Returned if telephony status is changed.
        /// Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        /// </summary>
        public string telephonyStatus;

        /// <summary>
        /// Order number of a notification to state the chronology
        /// </summary>
        public long? sequence;

        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// Enum: Offline, Busy, Available
        /// </summary>
        public string presenceStatus;

        /// <summary>
        /// User-defined presence status (as previously published by the user)
        /// Enum: Offline, Busy, Available
        /// </summary>
        public string userStatus;

        /// <summary>
        /// Extended DnD (Do not Disturb) status
        /// Enum: TakeAllCalls, DoNotAcceptAnyCalls, DoNotAcceptDepartmentCalls, TakeDepartmentCallsOnly
        /// </summary>
        public string dndStatus;

        /// <summary>
        /// If 'True' enables other extensions to see the extension presence status
        /// </summary>
        public bool? allowSeeMyPresence;

        /// <summary>
        /// If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        /// </summary>
        public bool? ringOnMonitoredCall;

        /// <summary>
        /// If 'True' enables the extension user to pick up a monitored line on hold
        /// </summary>
        public bool? pickUpCallsOnHold;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}