using DNF.Net.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationAuctionApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/auction";

		public async Task<DnfApplicationRecords<DnfApplicationAuctionItemSearch>?> GetAuctionItemSearchAsync(string itemName = "", string itemId = "", WordType wordType = WordType.Match, bool wordShort = true, int? minLevel = null, int? maxLevel = null, DnfItemRarityEnum? rarity = null, DnfReinforceTypeEnum? reinforceTypeId = null, int? minReinforce = null, int? maxReinforce = null, int? minRefine = null, int? maxRefine = null, int? minAdventureFame = null, int? maxAdventureFame = null, DnfSort? unitPrice = null, DnfSort? reinforce = null, DnfSort? auctionNo = null, int limit = 10)
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

        public async Task<DnfApplicationAuctionItemSearch?> GetAuctionItemAsync(int auctionNo)
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

        public async Task<DnfApplicationRecords<DnfApplicationAuctionQuoteSearch>?> GetAuctionQuoteSearchAsync(string itemName = "", string itemId = "", WordType wordType = WordType.Match, bool wordShort = true, int limit = 10)
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
