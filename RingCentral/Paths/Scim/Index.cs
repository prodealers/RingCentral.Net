namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public RestClient rc;
        public string version;

        public Index(RestClient rc, string version = "v2")
        {
            this.rc = rc;
            this.version = version;
        }

        public string Path()
        {
            if (version != null)
            {
                return $"/scim/{version}";
            }

            return "/scim";
        }
    }
}