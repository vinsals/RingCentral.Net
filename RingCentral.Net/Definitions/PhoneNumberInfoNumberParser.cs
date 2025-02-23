namespace RingCentral
{
    public class PhoneNumberInfoNumberParser
    {
        /// <summary>
        /// Area code of location. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a specific geographic region/numbering area of the national numbering plan (NANP); that can be summarized as `NPA-NXX-xxxx` and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See [North American Numbering Plan] (https://en.wikipedia.org/wiki/North_American_Numbering_Plan) for details
        /// </summary>
        public string areaCode;

        /// <summary>
        /// </summary>
        public GetCountryInfoNumberParser country;

        /// <summary>
        /// Dialing format of a phone number
        /// </summary>
        public string dialable;

        /// <summary>
        /// Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string e164;

        /// <summary>
        /// International format of a phone number
        /// </summary>
        public string formattedInternational;

        /// <summary>
        /// Domestic format of a phone number
        /// </summary>
        public string formattedNational;

        /// <summary>
        /// One of the numbers to be parsed, passed as a string in response
        /// </summary>
        public string originalString;

        /// <summary>
        /// 'True' if the number is in a special format (for example N11 code)
        /// </summary>
        public bool? special;

        /// <summary>
        /// Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format without plus sign ('+')
        /// </summary>
        public string normalized;

        /// <summary>
        /// Specifies if a phone number is toll free or not
        /// </summary>
        public bool? tollFree;

        /// <summary>
        /// Sub-Address. The portion of the number that identifies a subscriber into the subscriber internal (non-public) network.
        /// </summary>
        public string subAddress;

        /// <summary>
        /// Subscriber number. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a subscriber in a network or numbering area.
        /// </summary>
        public string subscriberNumber;

        /// <summary>
        /// DTMF (Dual Tone Multi-Frequency) postfix
        /// </summary>
        public string dtmfPostfix;
    }
}