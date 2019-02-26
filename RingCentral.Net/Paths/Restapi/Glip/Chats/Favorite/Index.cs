using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Favorite
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/favorite";
        }

        // Operation: favoriteGlipChat
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Favorite.Index Favorite()
        {
            return new Restapi.Glip.Chats.Favorite.Index(this);
        }
    }
}