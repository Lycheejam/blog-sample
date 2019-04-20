using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace hatebu_hot_download {
    public class Downloader {
        private static HttpClient client = new HttpClient();

        public Downloader() {
            client.DefaultRequestHeaders.Add(
                "User-Agent",
                "hogehoge"
            );
        }

        public async Task<string> GetBodyAsync (string url) {
            var response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        //public async Task<string> GetBodyAsync(string url) {
        //    using (var client = new HttpClient()) {
        //        var response = await client.GetStringAsync(url);
        //        return response;
        //    }
        //}
    }
}
