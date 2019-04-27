using System;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Dom;

namespace hatebu_hot_download {
    public class Parser {
        public Parser() {
        }

        public IHtmlDocument Run(string source) {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(source);

            return document;
        }

        public IHtmlCollection<IElement> GetHotEntry(IHtmlDocument document) {
            //cssと同じ様に指定するとはドキュメントに書いてあったけどスペース空けていいとは思わんだろ...
            var entries = document.QuerySelectorAll("h3.entrylist-contents-title a");

            return entries;
        }
    }
}
