using DNF.Net.Applications.Apis;

namespace DNF.Net.Applications
{
	/// <summary>
	/// 던전 앤 파이터 공식 API 문서 ->
	/// https://developers.neople.co.kr/contents/apiDocs/df
	/// </summary>
	public class DnfApplication(string apiKey)
	{
		public DnfApplicationImageApi ImageApi = new();
		public DnfApplicationServersApi ServersApi = new(apiKey);
		public DnfApplicationAuctionApi AuctionApi = new(apiKey);
		public DnfApplicationAvatarMarketApi AvatarMarketApi = new(apiKey);
		public DnfApplicationItemsApi ItemsApi = new(apiKey);
		public DnfApplicationItemHashtagApi ItemHashtagApi = new(apiKey);
		public DnfApplicationMultiApi MultiApi = new(apiKey);
		public DnfApplicationJobsApi JobsApi = new(apiKey);
		public DnfApplicationSkillsApi SkillsApi = new(apiKey);
		public DnfApplicationSetItemsApi SetItemsApi = new(apiKey);
		public DnfApplicationCustomApi CustomApi = new(apiKey);

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
