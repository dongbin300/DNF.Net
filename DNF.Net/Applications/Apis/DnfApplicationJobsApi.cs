using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationJobsApi
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/jobs";
        private string apiKey;

        public DnfApplicationJobsApi(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<DnfApplicationJobInfo>?> GetJobInfoAsync()
        {
            var url = GetDnfApplicationUrl(_baseUrl, apiKey);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationJobInfo>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
