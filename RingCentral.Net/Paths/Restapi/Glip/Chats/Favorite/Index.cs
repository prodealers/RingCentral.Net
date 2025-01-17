using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Favorite
{
    public class Index
    {
        public Chats.Index parent;
        public RestClient rc;

        public Index(Chats.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/favorite";
        }

        /// <summary>
        ///     Adds the specified chat to the users's list of favorites. **Note** 'Chat' is a general name for all types of
        ///     threads icluding *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants
        ///     without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat
        ///     including all employees, with a specific name)."
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/favorite
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Favorite.Index Favorite()
        {
            return new Favorite.Index(this);
        }
    }
}