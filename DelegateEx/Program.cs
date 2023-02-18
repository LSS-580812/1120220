using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    class Program
    {
        /// <summary>
        /// Delegate 委派三個步驟：
        /// 1.宣告委派型別。
        ///     [ public | protected | private ] delegate 回傳值型態 委派名稱 ( 參數群 )
        /// 2.實體化委派型別並指向相對應方法。
        ///     建立委派物件實體時，必須要傳入符合委派規格的方法參考
        /// 3.使用 Invoke 方法調用委派。
        ///     如果要將新的方法的位置參考加入到委派物件的執行方法清單的話，必須透過 「+=」 關鍵字。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            useDelegate calX = new useDelegate();
            calX.start();
            Console.ReadLine();
        }

        public class useDelegate
        {
            public delegate int Calculate(int x, int y);
            public Calculate myCalculateFunction;

            public void start()
            {
                Console.WriteLine("委派調用方式一");
                DoCalculate(5, 3, Add);
                DoCalculate(5, 3, Sub);

                Console.WriteLine("委派調用方式二");
                Calculate cal = new Calculate((x, y)=> { return x - y; }); //使用匿名函式
                Console.WriteLine(cal(10, 5));

                Console.WriteLine("委派調用方式三");
                myCalculateFunction += Add;
                myCalculateFunction += Sub;
                myCalculateFunction(2, 3);
            }

            void DoCalculate(int x, int y, Calculate cal)
            {
                var result = cal(x, y);
                Console.WriteLine($"cal:{result}");
            }

            int Add(int x, int y)
            { //實體化委派型別[相加]
                int result = x + y;
                Console.WriteLine($"x + y ={result}");
                return result;
            }

            int Sub(int x, int y)
            { //實體化委派型別[相減]
                int result = x - y;
                Console.WriteLine($"x - y ={result}");
                return result;
            }

            int Multiply(int x, int y)
            { //實體化委派型別[相乘]
                int result = x * y;
                Console.WriteLine($"x * y ={result}");
                return result;
            }

           

        }
    }
}
