using DNF.Net.Korean.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
    public class 경매장API
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/auction";
        private string apiKey;

        public 경매장API(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<DnfApplicationAuctionItemSearch>?> 경매장_등록_아이템_검색(string itemName = "", string itemId = "", 검색타입 wordType = 검색타입.동일단어, bool wordShort = true, int? minLevel = null, int? maxLevel = null, 아이템레어리티구조체? rarity = null, 강화타입구조체? reinforceTypeId = null, int? minReinforce = null, int? maxReinforce = null, int? minRefine = null, int? maxRefine = null, int? minAdventureFame = null, int? maxAdventureFame = null, 정렬? unitPrice = null, 정렬? reinforce = null, 정렬? auctionNo = null, int limit = 10)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "itemName", itemName },
                { "itemId", itemId },
                { "wordType", wordType.ToString() },
                { "wordShort", wordShort.ToString() },
                { "q",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        {"minLevel", minLevel.ToString() },
                        {"maxLevel", maxLevel.ToString() },
                        {"rarity", rarity?.Name },
                        {"reinforceTypeId", reinforceTypeId?.Name },
                        {"minReinforce", minReinforce.ToString() },
                        {"maxReinforce", maxReinforce.ToString() },
                        {"minRefine", minRefine.ToString() },
                        {"maxRefine", maxRefine.ToString() },
                        {"minAdventureFame", minAdventureFame.ToString() },
                        {"maxAdventureFame", maxAdventureFame.ToString() },
                    })
                },
                { "sort",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        { "unitPrice", unitPrice.ToString() },
                        { "reinforce", reinforce.ToString() },
                        { "auctionNo", auctionNo.ToString() },
                    })
                },
                { "limit", limit.ToString() }
            };

            var url = GetDnfApplicationUrl(_baseUrl, apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationAuctionItemSearch>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationAuctionItemSearch?> 경매장_등록_아이템_조회(int auctionNo)
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/{auctionNo}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationAuctionItemSearch>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationRecords<DnfApplicationAuctionQuoteSearch>?> 경매장_시세_검색(string itemName = "", string itemId = "", 검색타입 wordType = 검색타입.동일단어, bool wordShort = true, int limit = 10)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "itemName", itemName },
                { "itemId", itemId },
                { "wordType", wordType.ToString() },
                { "wordShort", wordShort.ToString() },
                { "limit", limit.ToString() }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}-sold", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationAuctionQuoteSearch>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
