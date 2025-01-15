using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
	public class 커스텀API(string apiKey)
	{
		private readonly HttpClient client = new();
		private readonly string _baseUrl = "https://api.neople.co.kr/df/custom";

		public async Task<DnfApplicationEquipmentSetItemActivationInfo?> 장비_조합_세트_아이템_활성화_정보_조회(IList<string> itemIds)
		{
			var parameters = new Dictionary<string, string?>
			{
				{ "itemIds", GetSerializedValues(itemIds) }
			};

			var url = GetDnfApplicationUrl($"{_baseUrl}/equipment/setitems", apiKey, parameters);

			try
			{
				return await RequestAsync<DnfApplicationEquipmentSetItemActivationInfo>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}
	}
}
