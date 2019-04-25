using System;
using System.Threading.Tasks;

namespace connection_zikken {
    public class Zikken {
        private readonly string _url;

        public Zikken() {
            _url = "http://todo.kitigai.org/zikken/";
        }

        public async Task BadPattern () {
            Console.WriteLine("悪い例1");

            var badclient = new HttpClientBadExample();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0}回目：{1}", i, await badclient.RunAsync(_url));
            }
        }

        public async Task GoodPattern () {
            Console.WriteLine("良い例");

            var goodclient = new HttpClientGoodExample();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0}回目：{1}", i, await goodclient.RunAsync(_url));
            }
        }
    }
}
