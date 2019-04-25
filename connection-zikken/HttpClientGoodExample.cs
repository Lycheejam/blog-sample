using System.Net.Http;
using System.Threading.Tasks;

namespace connection_zikken {
    public class HttpClientGoodExample {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<string> RunAsync (string url) {
            var response = await _client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
