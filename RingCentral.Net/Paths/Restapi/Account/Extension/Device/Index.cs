using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Device
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/device";
        }

        /// <summary>
        /// Operation: Get Extension Device List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/device
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserDevices
        /// </summary>
        public async Task<RingCentral.GetExtensionDevicesResponse> Get(
            ListExtensionDevicesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetExtensionDevicesResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Device.Index Device()
        {
            return new Restapi.Account.Extension.Device.Index(this);
        }
    }
}