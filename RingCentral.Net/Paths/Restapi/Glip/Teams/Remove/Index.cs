using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Remove
{
    public class Index
    {
        public Teams.Index parent;
        public RestClient rc;

        public Index(Teams.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/remove";
        }

        /// <summary>
        ///     Removes members from the specified team. A team is a chat between 2 and more participants assigned with specific
        ///     name.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}/remove
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(GlipPostMembersIdsListBody glipPostMembersIdsListBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), glipPostMembersIdsListBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Remove.Index Remove()
        {
            return new Remove.Index(this);
        }
    }
}