using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace connection_zikken {
    public class HttpClientBadExample {
        public async Task<string> RunAsync (string url) {
            var result = "";
            using (var client = new HttpClient()) {
                var response = await client.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }
    }
}
