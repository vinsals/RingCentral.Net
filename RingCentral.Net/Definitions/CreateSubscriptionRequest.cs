namespace RingCentral
{
    public class CreateSubscriptionRequest
    {
        /// <summary>
        /// Collection of URIs to API resources
        /// Required
        /// </summary>
        public string[] eventFilters;

        /// <summary>
        /// Required
        /// </summary>
        public NotificationDeliveryModeRequest deliveryMode;

        /// <summary>
        /// Subscription lifetime in seconds. Max value is 7 days (604800 sec). For *WebHook* transport type max value might be set up to 630720000 seconds (20 years)
        /// </summary>
        public long? expiresIn;
    }
}