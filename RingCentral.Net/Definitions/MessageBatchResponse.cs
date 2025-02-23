namespace RingCentral
{
    // Batch of A2P SMS messages. This object provides a specification to send message(s) to many recipients. It contains top-level attributes which apply to all messages. In addition to that, it is possible to override this attribute for each message. This way a single API call may be used to send individual messages to many recipients
    public class MessageBatchResponse
    {
        /// <summary>
        /// Unique identifier of the message batch
        /// </summary>
        public string id;

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the messages are going to be sent
        /// Required
        /// </summary>
        public string from;

        /// <summary>
        /// Total number of messages in the accepted batch
        /// </summary>
        public long? batchSize;

        /// <summary>
        /// Total number of messages currently processed in the batch
        /// </summary>
        public long? processedCount;

        /// <summary>
        /// The last time the batch was processed.
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Current status of a message batch
        /// Enum: Processing, Completed
        /// </summary>
        public string status;

        /// <summary>
        /// The time at which the batch was created
        /// </summary>
        public string creationTime;
    }
}