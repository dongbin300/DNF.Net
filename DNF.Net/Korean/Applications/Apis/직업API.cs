using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
	public class 직업API(string apiKey)
	{
		private readonly HttpClient client = new();
		private readonly string _baseUrl = "https://api.neople.co.kr/df/jobs";

		public async Task<DnfApplicationRecords<DnfApplicationJobInfo>?> 직업_정보()
		{
			var url = GetDnfApplicationUrl(_baseUrl, apiKey);

			try
			{
				return await RequestAsync<DnfApplicationRecords<DnfApplicationJobInfo>>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}
	}
}
