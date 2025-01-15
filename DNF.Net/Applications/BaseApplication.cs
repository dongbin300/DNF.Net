using System.Net;
using System.Text.Json;

namespace DNF.Net.Applications
{
    public class BaseApplication
    {
        public static string GetSerializedUrl(string baseUrl, Dictionary<string, string>? parameters = null)
        {
            if (parameters == null)
            {
                return baseUrl;
            }

            return baseUrl + "?" + string.Join("&", parameters.Select(x => x.Key + "=" + x.Value).ToArray());
        }

        public static async Task<T?> RequestAsync<T>(HttpClient client, string url)
        {
            try
            {
                var requestResult = await client.GetAsync(url).ConfigureAwait(false);

                var response = requestResult.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var jsonStringResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    T? data = JsonSerializer.Deserialize<T>(jsonStringResult);

                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            catch
            {
                throw;
            }
        }

        public static async Task<byte[]> RequestBytesAsync(HttpClient client, string url)
        {
            try
            {
                var requestResult = await client.GetAsync(url).ConfigureAwait(false);

                var response = requestResult.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
				{
					var result = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
					return result;
				}
				else
				{
					return [];
				}
			}
			catch
			{
				return [];
			}
		}
	}
}
