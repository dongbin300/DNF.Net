using DNF.Net.Korean.Enums;

using static DNF.Net.Applications.BaseApplication;

namespace DNF.Net.Korean.Applications.Apis
{
    public class 이미지API
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://img-api.neople.co.kr/df";

        public 이미지API()
        {

        }

        public string 캐릭터_이미지_URL(서버 server, string characterId, 캐릭터이미지줌 zoom = 캐릭터이미지줌.X1)
        {
            return $"{_baseUrl}/servers/{server}/characters/{characterId}?zoom={(int)zoom}";
        }

        public async Task<byte[]> 캐릭터_이미지_조회(서버 server, string characterId, 캐릭터이미지줌 zoom = 캐릭터이미지줌.X1)
        {
            var url = 캐릭터_이미지_URL(server, characterId, zoom);
            return await RequestBytesAsync(client, url).ConfigureAwait(false);
        }

        public string 아이템_이미지_URL(string itemId)
        {
            return $"{_baseUrl}/items/{itemId}";
        }

        public async Task<byte[]> 아이템_이미지_조회(string itemId)
        {
            var url = 아이템_이미지_URL(itemId);
            return await RequestBytesAsync(client, url).ConfigureAwait(false);
        }
    }
}
