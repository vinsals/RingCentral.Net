namespace RingCentral
{
    public class CompanyPhoneNumberInfo
    {
        /// <summary>
        /// Link to a company phone number resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        public long? id;

        /// <summary>
        /// </summary>
        public CountryInfo country;

        /// <summary>
        /// </summary>
        public ExtensionInfo extension;

        /// <summary>
        /// Custom user name of a phone number, if any
        /// </summary>
        public string label;

        /// <summary>
        /// Location (City, State). Filled for local US numbers
        /// </summary>
        public string location;

        /// <summary>
        /// Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        /// Enum: External, TollFree, Local, BusinessMobileNumberProvider
        /// </summary>
        public string paymentType;

        /// <summary>
        /// Phone number
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        /// </summary>
        public string status;

        /// <summary>
        /// Phone number type
        /// Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type;

        /// <summary>
        /// Usage type of a phone number. Usage type of a phone number. Numbers of 'NumberPool' type wont't be returned for phone number list requests
        /// Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, NumberPool, BusinessMobileNumber
        /// </summary>
        public string usageType;

        /// <summary>
        /// </summary>
        public TemporaryNumberInfo temporaryNumber;

        /// <summary>
        /// </summary>
        public ContactCenterProvider contactCenterProvider;

        /// <summary>
        /// Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern
        /// </summary>
        public string vanityPattern;
    }
}