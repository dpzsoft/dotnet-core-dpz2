using System;

namespace demo {
    class Program {
        static void Main(string[] args) {
            var ver = new dpz2.TimeVersion();
            Console.WriteLine(ver.ToString());
            var ver2 = ver.GetNextVersion();
            Console.WriteLine(ver2.ToString());
            var ver3 = ver2.GetNextVersion();
            Console.WriteLine(ver3.ToString());

            var vn = new dpz2.TimeVersion("1.1.1908.5");
            Console.WriteLine("vn:" + vn.ToString());
            var vn2 = vn.GetNextVersion();
            Console.WriteLine("vn2:" + vn2.ToString());
            var vn3 = vn2.GetNextVersion();
            Console.WriteLine("vn3:" + vn3.ToString());
        }
    }
}
