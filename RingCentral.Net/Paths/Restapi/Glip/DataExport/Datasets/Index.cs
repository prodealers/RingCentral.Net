using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.DataExport.Datasets
{
    public partial class Index
    {
        public RestClient rc;
        public string datasetId;
        public Restapi.Glip.DataExport.Index parent;

        public Index(Restapi.Glip.DataExport.Index parent, string datasetId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.datasetId = datasetId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && datasetId != null)
            {
                return $"{parent.Path()}/datasets/{datasetId}";
            }

            return $"{parent.Path()}/datasets";
        }

        /// <summary>
        /// Returns the specified dataset by ID. Each dataset is a ZIP archive the size of which is limited to 1 Gb.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId}
        /// Rate Limit Group: Heavy
        /// App Permission: Glip
        /// User Permission: undefined
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.datasetId == null)
            {
                throw new System.ArgumentNullException("datasetId");
            }

            return await rc.Get<byte[]>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.DataExport
{
    public partial class Index
    {
        public Restapi.Glip.DataExport.Datasets.Index Datasets(string datasetId = null)
        {
            return new Restapi.Glip.DataExport.Datasets.Index(this, datasetId);
        }
    }
}