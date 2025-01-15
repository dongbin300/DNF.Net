using DNF.Net.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationSetItemsApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/setitems";

		public async Task<DnfApplicationRecords<DnfApplicationSetItem>?> GetSetItemSearchAsync(string setItemName, WordType wordType = WordType.Match, int limit = 10)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "setItemName", setItemName },
                { "wordType", wordType.ToString() },
                { "limit", limit.ToString() }
            };

            var url = GetDnfApplicationUrl(_baseUrl, apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationSetItem>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationSetItemDetail?> GetSetItemDetailAsync(string setItemId)
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/{setItemId}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationSetItemDetail>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
