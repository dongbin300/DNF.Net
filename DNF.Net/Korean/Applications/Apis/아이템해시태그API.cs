using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;

namespace DNF.Net.Korean.Applications.Apis
{
    public class 아이템해시태그API
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/item-hashtag";
        private string apiKey;

        public 아이템해시태그API(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationRecords<string>?> 아이템_해시태그()
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
