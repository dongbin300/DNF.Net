using DNF.Net.Korean.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
    public class 세트아이템API
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/setitems";
        private string apiKey;

        public 세트아이템API(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<DnfApplicationSetItem>?> 세트_아이템_검색(string setItemName, 검색타입 wordType = 검색타입.동일단어, int limit = 10)
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

        public async Task<DnfApplicationSetItemDetail?> 세트_아이템_상세_정보_조회(string setItemId)
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
