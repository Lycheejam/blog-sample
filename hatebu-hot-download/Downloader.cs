using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace hatebu_hot_download {
    public class Downloader {
        private readonly Uri _url;
        private static HttpClient _client = new HttpClient();

        public Downloader(string url) {
            _url = new Uri(url);
            _client.DefaultRequestHeaders.Add(
                "User-Agent",
                "hogehoge"
            );
        }

        public async Task<string> GetBodyAsync () {
            var response = await _client.GetAsync(_url);
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
