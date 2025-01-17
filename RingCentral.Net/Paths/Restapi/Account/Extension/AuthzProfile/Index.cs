using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile
{
    public partial class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/authz-profile";
        }

        /// <summary>
        ///     Returns the list of user permissions granted at authorization procedure. Please note: Some permissions may be
        ///     restricted by extension type.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/authz-profile
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<AuthProfileResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AuthProfileResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AuthzProfile.Index AuthzProfile()
        {
            return new AuthzProfile.Index(this);
        }
    }
}