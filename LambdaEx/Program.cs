using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEx
{
    class Program
    {
        static void Main(string[] args)
        { //以 lambda 運算式取代匿名方法委派
            MyDelegate d;
            d = (int x, int y) => { return x + y; };
            var a = d(1, 2);
            Console.WriteLine(a);

            d = (x, y) => x - y; //lambda 甚至可以省去傳入參數的型別與 return 關鍵字
            var b = d(2, 1);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public delegate int MyDelegate(int x, int y);

    }
}
