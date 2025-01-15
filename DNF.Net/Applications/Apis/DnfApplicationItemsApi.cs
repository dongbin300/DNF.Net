using DNF.Net.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationItemsApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/items";

		public async Task<DnfApplicationRecords<DnfApplicationItemSearch>?> GetItemSearchAsync(string itemName = "", IList<string>? hashtags = null, WordType wordType = WordType.Match, int? minLevel = null, int? maxLevel = null, DnfItemRarityEnum? rarity = null, int limit = 10)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "itemName", itemName },
                { "hashtag", GetSerializedValues(hashtags) },
                { "wordType", wordType.ToString() },
                { "q",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        {"minLevel", minLevel?.ToString() },
                        {"maxLevel", maxLevel?.ToString() },
                        {"rarity", rarity?.Name },
                    })
                },
                { "limit", limit.ToString() }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationItemSearch>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationItemDetail?> GetItemDetailAsync(string itemId)
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/{itemId}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationItemDetail>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationItemShopSales?> GetItemShopSalesInfoAsync(string itemId)
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/{itemId}/shop", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationItemShopSales>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
