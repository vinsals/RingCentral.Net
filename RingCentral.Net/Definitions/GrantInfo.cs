namespace RingCentral
{
    public class GrantInfo
    {
        /// <summary>
        /// Canonical URI of a grant
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public ExtensionInfoGrants extension;

        /// <summary>
        /// Specifies if picking up of other extensions' calls is allowed for the extension. If 'Presence' feature is disabled for the given extension, the flag is not returned
        /// </summary>
        public bool? callPickup;

        /// <summary>
        /// Specifies if monitoring of other extensions' calls is allowed for the extension. If 'CallMonitoring' feature is disabled for the given extension, the flag is not returned
        /// </summary>
        public bool? callMonitoring;

        /// <summary>
        /// Specifies whether the current extension is able to make or receive calls on behalf of the user referenced in extension object
        /// </summary>
        public bool? callOnBehalfOf;

        /// <summary>
        /// Specifies whether the current extension can delegate a call to the user referenced in extension object
        /// </summary>
        public bool? callDelegation;

        /// <summary>
        /// Specifies whether the current extension is allowed to call Paging Only group referenced to in extension object
        /// </summary>
        public bool? groupPaging;

        /// <summary>
        /// Specifies whether the current extension is assigned as a Full-Access manager in the call queue referenced in extension object
        /// </summary>
        public bool? callQueueSetup;

        /// <summary>
        /// Specifies whether the current extension is assigned as a Members-Only manager in the call queue referenced in extension object
        /// </summary>
        public bool? callQueueMembersSetup;
    }
}