using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

namespace hatebu_hot_download {
    class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            var url = "http://b.hatena.ne.jp/hotentry/all";

            var downloder = new Downloader(url);
            var dlresult = await downloder.GetBodyAsync();
            Console.WriteLine(dlresult);

            var parser = new Parser();
            var document = await parser.RunAsync(dlresult);

            Console.WriteLine(document.Title);

            var title = document.QuerySelectorAll("h3.entrylist-contents-title");

            foreach (var item in title) {
                Console.WriteLine(item.TextContent);
            }
        }
    }
}