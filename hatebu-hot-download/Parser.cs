using System;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace hatebu_hot_download {
    public class Parser {
        public Parser() {
        }

        public async Task<IHtmlDocument> RunAsync(string source) {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(source);

            return document;
        }
    }
}
