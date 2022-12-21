using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationCustomApi
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/custom";
        private string apiKey;

        public DnfApplicationCustomApi(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationEquipmentSetItemActivationInfo?> GetEquipmentSetItemActivationInfoAsync(IList<string> itemIds)
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
