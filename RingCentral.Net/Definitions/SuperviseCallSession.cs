namespace RingCentral
{
    public class SuperviseCallSession
    {
        /// <summary>
        /// </summary>
        public SupervisePartyFrom from;

        /// <summary>
        /// </summary>
        public SupervisePartyTo to;

        /// <summary>
        /// Direction of a call
        /// Enum: Outbound, Inbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Internal identifier of a party that monitors a call
        /// </summary>
        public string id;

        /// <summary>
        /// Internal identifier of an account that monitors a call
        /// </summary>
        public string accountId;

        /// <summary>
        /// Internal identifier of an extension that monitors a call
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted;

        /// <summary>
        /// </summary>
        public OwnerInfo owner;

        /// <summary>
        /// If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone;

        /// <summary>
        /// </summary>
        public CallStatusInfo status;
    }
}