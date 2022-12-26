using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
    public class 멀티API
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/multi";
        private string apiKey;

        public 멀티API(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<DnfApplicationItemDetail>?> 다중_아이템_상세_정보_조회(IList<string> itemIds)
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

        public async Task<DnfApplicationRecords<DnfApplicationSetItemDetail>?> 다중_세트_아이템_상세_정보_조회(IList<string> setItemIds)
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
