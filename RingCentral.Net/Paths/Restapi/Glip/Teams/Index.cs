using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public RestClient rc;
        public string chatId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/teams/{chatId}";
            }

            return $"{parent.Path()}/teams";
        }

        /// <summary>
        /// Returns the list of teams where the user is a member (both archived and active) combined with a list of public teams that can be joined by the current user. All records in response are sorted by creation time of a chat in ascending order. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/teams
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamsList> List(ListGlipTeamsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipTeamsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a team, and adds a list of people to the team.  A team is a chat between 2 and more (unlimited number) participants assigned with specific name.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamInfo> Post(RingCentral.GlipPostTeamBody glipPostTeamBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipTeamInfo>(this.Path(false), glipPostTeamBody, null, restRequestConfig);
        }

        /// <summary>
        /// Returns information about the specified team. A team is a chat between 2 and more participants assigned with specific name.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipTeamInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified team. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the name and description of the specified team. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamInfo> Patch(RingCentral.GlipPatchTeamBody glipPatchTeamBody,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Patch<RingCentral.GlipTeamInfo>(this.Path(), glipPatchTeamBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Index Teams(string chatId = null)
        {
            return new Restapi.Glip.Teams.Index(this, chatId);
        }
    }
}