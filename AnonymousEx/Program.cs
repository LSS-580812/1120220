using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousEx
{
    class Program
    {
        static void Main(string[] args)
        { //匿名函式委派
            MyDelegate d;
            d = delegate (int x, int y) { return x + y; };
            var a = d(1, 2);
            Console.WriteLine(a);

            Console.ReadKey();
        }

        public delegate int MyDelegate(int x, int y);
    }
}
