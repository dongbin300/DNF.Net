using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationItemHashtagApi
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/item-hashtag";
        private string apiKey;

        public DnfApplicationItemHashtagApi(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<string>?> GetItemHashtagAsync()
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationRecords<string>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
