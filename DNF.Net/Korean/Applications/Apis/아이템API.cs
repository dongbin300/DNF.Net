using DNF.Net.Korean.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
    public class 아이템API
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/items";
        private string apiKey;

        public 아이템API(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<DnfApplicationItemSearch>?> 아이템_검색(string itemName = "", IList<string>? hashtags = null, 검색타입 wordType = 검색타입.동일단어, int? minLevel = null, int? maxLevel = null, 아이템레어리티구조체? rarity = null, int limit = 10)
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

        public async Task<DnfApplicationItemDetail?> 아이템_상세_정보_조회(string itemId)
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

        public async Task<DnfApplicationItemShopSales?> 아이템_상점_판매_정보_조회(string itemId)
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
