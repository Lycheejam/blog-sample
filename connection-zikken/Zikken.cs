using System;
using System.Threading.Tasks;

namespace connection_zikken {
    public class Zikken {
        private readonly string _url;

        public Zikken() {
            _url = "http://todo.kitigai.org/zikken/";
        }

        public async Task BadPatternA () {
            Console.WriteLine("悪い例1");

            var badclient = new HttpClientBadExample();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0}回目：{1}", i, await badclient.RunAsync(_url));
            }
        }

        public async Task BadPatternB () {
            Console.WriteLine("悪い例2");

            for (int i = 0; i < 10; i++) {
                var badclient = new HttpClientBadExample();
                Console.WriteLine("{0}回目：{1}", i, await badclient.RunAsync(_url));
            }
        }

        public async Task GoodPatternA () {
            Console.WriteLine("良い例1");

            var goodclient = new HttpClientGoodExample();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0}回目：{1}", i, await goodclient.RunAsync(_url));
            }
        }

        public async Task GoodPatternB () {
            Console.WriteLine("良い例2");

            for (int i = 0; i < 10; i++) {
                var goodclient = new HttpClientGoodExample();
                Console.WriteLine("{0}回目：{1}", i, await goodclient.RunAsync(_url));
            }
        }
    }
}
