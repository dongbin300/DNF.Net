using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationMultiApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/multi";

		public async Task<DnfApplicationRecords<DnfApplicationItemDetail>?> GetMultiItemSearchAsync(IList<string> itemIds)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "itemIds", GetSerializedValues(itemIds) }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}/items", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationItemDetail>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationRecords<DnfApplicationSetItemDetail>?> GetMultiSetItemSearchAsync(IList<string> setItemIds)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "setItemIds", GetSerializedValues(setItemIds) }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}/setitems", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationSetItemDetail>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
