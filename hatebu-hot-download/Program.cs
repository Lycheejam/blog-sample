using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace hatebu_hot_download {
    class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            var url = "http://b.hatena.ne.jp/hotentry/all";

            var downloder = new Downloader();
            Console.WriteLine(await downloder.GetBodyAsync(url));
        }
    }
}