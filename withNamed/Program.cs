using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withNamed
{
    class Program
    {
        static void Main(string[] args)
        { //具名函式委派
            MyDelegate d;
            d = new MyDelegate(add);
            var a = d(1, 2);
            Console.WriteLine(a);

            d = new MyDelegate(subtract);
            var b= d(2, 1);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public delegate int MyDelegate(int x, int y);
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
    }
}
