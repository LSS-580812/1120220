using StaticClassEx.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassEx
{
    internal class Program
    {
        static void Main(string[] args)
        { //靜態類別和靜態類別成員
            /*
             * 不能使用 new 運算子來建立類別型別的變數。 無法產生實體
             * 只包含靜態成員
             * 一定是密封的, 無法被繼承
             * 基底類別只能是 Object Type
             * 沒有執行個體建構函式
             * 如果要一個類別只有靜態成員，設計成靜態類別是不錯的想法
             * 我們最常用靜態類別的情境在建立擴充方法的時候
            */
            Class1.Execute();

            List<string> source = new List<string> { "Bill", "John", "David", "Tom", "David" };
            var result = source.DoWhere((x) => x == "David");
            // 其實它原來應該是這樣寫
            // var result = MyClass.DoWhere(source, ((x) => x == "David"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }

    public static class Class1
    {
        private static int x = 100;
        public static void Execute()
        {
            Console.WriteLine($"This is {x}");
        }
    }


}
