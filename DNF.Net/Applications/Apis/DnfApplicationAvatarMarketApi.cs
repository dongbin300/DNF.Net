using DNF.Net.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationAvatarMarketApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/avatar-market";

		public async Task<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>?> GetAvatarMarketItemSearchAsync(string title = "", IList<string>? hashtags = null, WordType wordType = WordType.Match, string jobId = "", DnfAvatarMarketEmblem emblemCode = DnfAvatarMarketEmblem.None, bool? avatarSet = null, string avatarRarity = "", int? minPrice = null, int? maxPrice = null, int? minAvatarCount = null, int? maxAvatarCount = null, DnfSort? price = null, DnfSort? goodsNo = null, int limit = 10)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "title", title },
                { "hashtag", GetSerializedValues(hashtags) },
                { "wordType", wordType.ToString() },
                { "q",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        {"jobId", jobId },
                        {"emblemCode", ((int)emblemCode).ToString() },
                        {"avatarSet", avatarSet?.ToString() },
                        {"avatarRarity", avatarRarity },
                        {"minPrice", minPrice?.ToString() },
                        {"maxPrice", maxPrice?.ToString() },
                        {"minAvatarCount", minAvatarCount?.ToString() },
                        {"maxAvatarCount", maxAvatarCount?.ToString() }
                    })
                },
                { "sort",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        { "price", price.ToString() },
                        { "goodsNo", goodsNo.ToString() }
                    })
                },
                { "limit", limit.ToString() }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}/sale", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationAvatarMarketItemSearch?> GetAvatarMarketItemAsync(int goodsNo)
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/sale/{goodsNo}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationAvatarMarketItemSearch>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>?> GetAvatarMarketQuoteSearchAsync(string title = "", IList<string>? hashtags = null, WordType wordType = WordType.Match, string jobId = "", DnfAvatarMarketEmblem emblemCode = DnfAvatarMarketEmblem.None, bool? avatarSet = null, string avatarRarity = "", int? minPrice = null, int? maxPrice = null, int? minAvatarCount = null, int? maxAvatarCount = null, DnfSort? price = null, DnfSort? goodsNo = null, int limit = 10)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "title", title },
                { "hashtag", GetSerializedValues(hashtags) },
                { "wordType", wordType.ToString() },
                { "q",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        {"jobId", jobId },
                        {"emblemCode", ((int)emblemCode).ToString() },
                        {"avatarSet", avatarSet?.ToString() },
                        {"avatarRarity", avatarRarity },
                        {"minPrice", minPrice?.ToString() },
                        {"maxPrice", maxPrice?.ToString() },
                        {"minAvatarCount", minAvatarCount?.ToString() },
                        {"maxAvatarCount", maxAvatarCount?.ToString() }
                    })
                },
                { "sort",
                    GetSerializedSubParameters(new Dictionary<string, string?>
                    {
                        { "price", price.ToString() },
                        { "goodsNo", goodsNo.ToString() }
                    })
                },
                { "limit", limit.ToString() }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}/sold", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationAvatarMarketItemSearch?> GetAvatarMarketQuoteAsync(int goodsNo)
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/sold/{goodsNo}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationAvatarMarketItemSearch>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationRecords<string>?> GetAvatarMarketHashtagAsync()
        {
            var url = GetDnfApplicationUrl($"{_baseUrl}/hashtag", apiKey);

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
