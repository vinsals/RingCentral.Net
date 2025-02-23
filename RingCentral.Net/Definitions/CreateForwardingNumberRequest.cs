namespace RingCentral
{
    public class CreateForwardingNumberRequest
    {
        /// <summary>
        /// Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        public long? flipNumber;

        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Forwarding/Call flip number title
        /// </summary>
        public string label;

        /// <summary>
        /// Forwarding/Call flip phone type. If specified, 'label' attribute value is ignored. The default value is 'Other'
        /// Enum: PhoneLine, Home, Mobile, Work, Other
        /// </summary>
        public string type;

        /// <summary>
        /// </summary>
        public CreateForwardingNumberDeviceInfo device;
    }
}