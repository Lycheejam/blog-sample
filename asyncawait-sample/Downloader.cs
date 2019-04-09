using System;
using System.Net;
using System.Threading.Tasks;

namespace asyncawait_sample {
    public class Downloader {

        public Downloader() { }

        //同期メソッド
        public string BlogDownload(string url) {
            using (var client = new WebClient()) {
                Console.WriteLine("Download Start url:{0}", url);
                var text = client.DownloadString(url);

                Console.WriteLine("Download Complete url:{0}", url);
                Console.WriteLine("");

                return text;
            }
        }

        //非同期メソッド
        public async Task<string> BlogDownloadAsync(string url) {
            using (var client = new WebClient()) {
                Console.WriteLine("Download Start url:{0}", url);
                var text = await client.DownloadStringTaskAsync(url);

                Console.WriteLine("Download Complete url:{0}", url);
                Console.WriteLine("");

                return text;
            }
        }
    }
}
