using DNF.Net.Korean.Applications.Apis;

namespace DNF.Net.Korean.Applications
{
	/// <summary>
	/// 던전 앤 파이터 공식 API 문서 ->
	/// https://developers.neople.co.kr/contents/apiDocs/df
	/// </summary>
	public class 던파앱(string apiKey)
	{
		public 이미지API 이미지API = new();
		public 서버API 서버API = new(apiKey);
		public 경매장API 경매장API = new(apiKey);
		public 아바타마켓API 아바타마켓API = new(apiKey);
		public 아이템API 아이템API = new(apiKey);
		public 아이템해시태그API 아이템해시태그API = new(apiKey);
		public 멀티API 멀티API = new(apiKey);
		public 직업API 직업API = new(apiKey);
		public 스킬API 스킬API = new(apiKey);
		public 세트아이템API 세트아이템API = new(apiKey);
		public 커스텀API 커스텀API = new(apiKey);

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
