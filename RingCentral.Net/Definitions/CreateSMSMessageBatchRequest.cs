namespace RingCentral
{
    // Batch of A2P SMS messages. This object provides specification to send message(s) to many recipients. It contains top-level attributes, such as `text` which apply to all `messages`. In addition to that, it is possible to override this attribute for each message. This way a single API call may be used to send individual messages to many recipients.
    public class CreateSMSMessageBatchRequest
    {
        /// <summary>
        /// Sender's phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format.
        /// Required
        /// </summary>
        public string from;

        /// <summary>
        /// Text to send to `messages.to` phone numbers. Can be overridden on a per-message basis
        /// </summary>
        public string text;

        /// <summary>
        /// Individual messages
        /// Required
        /// </summary>
        public MessageCreateRequest[] messages;
    }
}