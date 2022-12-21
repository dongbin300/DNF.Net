using DNF.Net.Applications.Apis;

namespace DNF.Net.Applications
{
    /// <summary>
    /// 던전 앤 파이터 공식 API 문서 ->
    /// https://developers.neople.co.kr/contents/apiDocs/df
    /// </summary>
    public class DnfApplication
    {
        public DnfApplicationImageApi ImageApi;
        public DnfApplicationServersApi ServersApi;
        public DnfApplicationAuctionApi AuctionApi;
        public DnfApplicationAvatarMarketApi AvatarMarketApi;
        public DnfApplicationItemsApi ItemsApi;
        public DnfApplicationItemHashtagApi ItemHashtagApi;
        public DnfApplicationMultiApi MultiApi;
        public DnfApplicationJobsApi JobsApi;
        public DnfApplicationSkillsApi SkillsApi;
        public DnfApplicationSetItemsApi SetItemsApi;
        public DnfApplicationCustomApi CustomApi;

        public DnfApplication(string apiKey)
        {
            ImageApi = new DnfApplicationImageApi();
            ServersApi = new DnfApplicationServersApi(apiKey);
            AuctionApi = new DnfApplicationAuctionApi(apiKey);
            AvatarMarketApi = new DnfApplicationAvatarMarketApi(apiKey);
            ItemsApi = new DnfApplicationItemsApi(apiKey);
            ItemHashtagApi = new DnfApplicationItemHashtagApi(apiKey);
            MultiApi = new DnfApplicationMultiApi(apiKey);
            JobsApi = new DnfApplicationJobsApi(apiKey);
            SkillsApi = new DnfApplicationSkillsApi(apiKey);
            SetItemsApi = new DnfApplicationSetItemsApi(apiKey);
            CustomApi = new DnfApplicationCustomApi(apiKey);
        }

        public static string GetDnfApplicationUrl(string baseUrl, string apiKey = "", Dictionary<string, string?>? parameters = null)
        {
            string result = baseUrl;

            if (!string.IsNullOrEmpty(apiKey))
            {
                if (parameters == null)
                {
                    result += "?apikey=" + apiKey;
                }
                else
                {
                    result += "?apikey=" + apiKey + "&" + string.Join("&", parameters.Where(x => !string.IsNullOrEmpty(x.Value)).Select(x => x.Key + "=" + x.Value).ToArray());
                }
            }

            return result;
        }

        public static string GetSerializedSubParameters(Dictionary<string, string?>? subParameters)
        {
            if (subParameters == null)
            {
                return string.Empty;
            }

            return string.Join(',', subParameters.Where(x => !string.IsNullOrEmpty(x.Value)).Select(x => x.Key + ":" + x.Value).ToArray());
        }

        public static string? GetSerializedValues<T>(IEnumerable<T>? values)
        {
            if (values == null)
            {
                return null;
            }

            return string.Join(',', values);
        }
    }
}
