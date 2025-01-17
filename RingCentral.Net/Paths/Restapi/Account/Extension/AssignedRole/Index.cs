using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AssignedRole
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
            return $"{parent.Path()}/assigned-role";
        }

        /// <summary>
        ///     Returns the list of roles assigned to the current extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<AssignedRolesResource> Get(ListUserAssignedRolesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AssignedRolesResource>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates the list of assigned roles for the current user.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        /// </summary>
        public async Task<AssignedRolesResource> Put(AssignedRolesResource assignedRolesResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<AssignedRolesResource>(Path(), assignedRolesResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AssignedRole.Index AssignedRole()
        {
            return new AssignedRole.Index(this);
        }
    }
}