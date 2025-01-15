using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationItemHashtagApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/item-hashtag";

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
