using System;
using System.Threading.Tasks;

namespace connection_zikken {
    class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            var url = "http://todo.kitigai.org/zikken/";

            //Console.WriteLine("悪い例");

            //var badclient = new HttpClientBadExample();

            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine("{0}回目：{1}", i, await badclient.RunAsync(url));
            //}

            Console.WriteLine("良い例");

            var goodclient = new HttpClientGoodExample();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0}回目：{1}", i, await goodclient.RunAsync(url));
            }
        }
    }
}
