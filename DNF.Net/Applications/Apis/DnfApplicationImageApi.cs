using DNF.Net.Enums;

using static DNF.Net.Applications.BaseApplication;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationImageApi
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://img-api.neople.co.kr/df";

        public DnfApplicationImageApi()
        {

        }

        public string GetCharacterImageUrl(DnfServer server, string characterId, DnfCharacterImageZoom zoom = DnfCharacterImageZoom.X1)
        {
            return $"{_baseUrl}/servers/{server}/characters/{characterId}?zoom={(int)zoom}";
        }

        public async Task<byte[]> GetCharacterImageAsync(DnfServer server, string characterId, DnfCharacterImageZoom zoom = DnfCharacterImageZoom.X1)
        {
            var url = GetCharacterImageUrl(server, characterId, zoom);
            return await RequestBytesAsync(client, url).ConfigureAwait(false);
        }

        public string GetItemImageUrl(string itemId)
        {
            return $"{_baseUrl}/items/{itemId}";
        }

        public async Task<byte[]> GetItemImageAsync(string itemId)
        {
            var url = GetItemImageUrl(itemId);
            return await RequestBytesAsync(client, url).ConfigureAwait(false);
        }
    }
}
