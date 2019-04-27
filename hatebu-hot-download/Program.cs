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
            var body = await downloder.GetBodyAsync();

            var parser = new Parser();
            var document = parser.Run(body);

            Console.WriteLine(document.Title);

            var entries = parser.GetHotEntry(document);

            Console.WriteLine("件数：{0}", entries.Count());

            foreach (var entry in entries) {
                Console.WriteLine("{0} | {1}", entry.Attributes["title"].Value, entry.Attributes["href"].Value);
                //Console.WriteLine(link.Attributes["title"].Value);
                //Console.WriteLine(link.Attributes["href"].Value);
            }
        }
    }
}