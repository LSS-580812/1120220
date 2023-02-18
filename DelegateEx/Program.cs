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
        /// 
        /// 教學資源：
        /// 1.【阿空】C# 委派 Delegate 用途大解析！ ( C# Delegate)(10:05)  https://www.youtube.com/watch?v=qeX96Dzx1fw
        /// 2.[C#] 委派 (Delegate)    https://dotblogs.com.tw/atowngit/2009/12/07/12311
        /// 3..NET/C# 委托(Delegate)和事件(Event)之语言进阶(2:31:19)   https://www.youtube.com/watch?v=IzKCT34nVoE
        /// 4,DAY 17 委派     https://ithelp.ithome.com.tw/articles/10205614
        /// 
        /// ILSpy 開源工具  https://ithelp.ithome.com.tw/articles/10220554
        ///     ILSpy是一個開源工具，可以將C#編譯而成的.dll或.exe等可執行檔，依照其中的中繼語言(IL)與相關資訊轉換為C#程式碼。而這一個將C#編譯出的IL再轉換回原本的C#的過程，專業術語叫做反編譯。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            useDelegate calX = new useDelegate();
            calX.Start();
            Console.ReadLine();
        }

        
        public class useDelegate
        {
            /* 委派型別宣告方式三種：1,具名函式 2,匿名函式 3,Lambda運算式
             * 1,具名函式: 將已宣告的方法(nameMethod)指給委派
             *      委派需要事先宣告此委派類型的傳入參數與傳回值，至少 0 個參數，至多 32 個參數，可以無傳回值，也可以指定傳回值類型。
             *      宣告位置，可以放置類別外部(全域)，也可以在類別內(區域)
             *      注意：參數與傳回型別需一致
             *      public delegate void NoReturnNoPara(); //無回傳值 | 無參數
             *      public delegate void NoReturnWithPara(int x, int y); //無回傳值 | 有參數 *一般聲明委派
             *      public delegate int WithReturnNoPara(); //有回傳值 | 無參數
             *      public delegate string WithReturnWithPara(out int x, ref int y); //有回傳值 | 有參數
             *      public delegate void NoReturnWithPara<T>(T t); //泛型委派
             *      public delegate void NoReturnNoParaOutClass(); //在類別外宣告
             *      
             * 2,匿名函式: delegate (arguments) { statements }
             *      delegate: 匿名函式的的保留字
             *      arguments: 傳入參數的宣告，可以多個參數(以,隔開)
             *      statements: 此函式執行的程式碼片段
             *      
             * 3,運算式 Lambda: arguments => expression | block
             *      arguments: 傳入參數的宣告，可以多個參數(以,隔開)。
             *          只有一個參數時可以不用括號，多個參數時都要加上括號
             *          可以不用明確指定型別
             *          可以明確指定型別
             *          明確指定型別時一定要加上括號
             *          沒有傳入參數時用空括號 () 表示
             *      expression: 運算式，不括大括號 {} ，只能單行程式碼，代表回傳值
             *      block: { statements }: 程式碼區塊，statement為此函式執行的程式碼片段
             * 
             * 4,委派的聲明除了 Delegate 也可以使用 Action, Func, Predicate 這些類型來進行委派，不用事先宣告委派的類型。
             *      Action是無傳回值的泛型委派。
             *      Func 是有傳回值的泛型委派。
             *      Predicate 是返回 bool 型的泛型委派。
             */





            public delegate int Calculate(int x, int y);
            public Calculate myCalculateFunction;

            public void Start()
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
                /* 委派實例調用
                 *  1,method.Invoke(); //使用 Invoke 方法
                 *  2,metgod(); //直接呼叫方法
                 *  3,this.DoNothing(); //調用委派實例方法
                */
            }

            public void Stop()
            {
                Console.WriteLine("釋放");
                myCalculateFunction -= Add;
                myCalculateFunction -= Sub;

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
