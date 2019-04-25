using System;
using System.Threading.Tasks;

namespace connection_zikken {
    class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            var zikken = new Zikken();

            //await zikken.BadPatternA();
            //await zikken.BadPatternB();
            //await zikken.GoodPatternA();
            await zikken.GoodPatternB();
        }
    }
}
