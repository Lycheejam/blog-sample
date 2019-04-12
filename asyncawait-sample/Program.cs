using System;
using System.Threading.Tasks;

namespace asyncawait_sample {
    class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            var dlclient = new Downloader();

            //同期メソッド
            //dlclient.BlogDownload();
            Console.WriteLine("同期メソッド");
            dlclient.BlogDownload("https://kitigai.hatenablog.com/entry/2019/04/04/133432");
            dlclient.BlogDownload("https://kitigai.hatenablog.com/entry/2019/04/03/155921");
            dlclient.BlogDownload("https://kitigai.hatenablog.com/entry/2019/04/01/203347");

            //非同期メソッド
            Console.WriteLine("非同期メソッド");
            var tasks = new Task[] {
                Task.Run(() => dlclient.BlogDownloadAsync("https://kitigai.hatenablog.com/entry/2019/04/04/133432")),
                Task.Run(() => dlclient.BlogDownloadAsync("https://kitigai.hatenablog.com/entry/2019/04/03/155921")),
                Task.Run(() => dlclient.BlogDownloadAsync("https://kitigai.hatenablog.com/entry/2019/04/01/203347"))
            };

            Console.WriteLine("この間に非同期メソッドが実行されてるよ。");

            await Task.WhenAll(tasks);
        }
    }
}
