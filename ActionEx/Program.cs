using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionEx
{
    class Program
    {
        static void Main(string[] args)
        { //Action 是無傳回值的泛型委派。
            Action<string> action = action1;
            action("123");

            action = action2;
            action("456");

            Console.ReadKey();
        }

        public static void action1(string a)
        {
            Console.WriteLine($"This Action1= {a}");
        }

        public static void action2(string b)
        {
            Console.WriteLine($"This Action1= {b}");
        }
    }
}
