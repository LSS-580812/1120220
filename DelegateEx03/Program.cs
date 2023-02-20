using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateEx03.Program;

namespace DelegateEx03
{
    public delegate bool MyPredicate(string value);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // 建立來源資料
            List<string> source = new List<string> { "Bill", "John", "David", "Tom", "David" };
            MyCalss obj = new MyCalss();

            /*具名委派
            MyPredicate predicate = SearchDavid; //
            var result = obj.DoWhere(source, predicate); Display(result);

            result = obj.DoWhere(source, SearchTom); Display(result);
            */

            /*匿名委派*/
            var result = obj.DoWhere(source, delegate(string x) { return x == "David"; });
            Display(result);

            /*Lambda*/
            result = obj.DoWhere(source, (x) => { return x == "John"; });
            Display(result);

            result = obj.DoWhere(source, x => { return x == "Tom"; });
            Display(result);

            result = obj.DoWhere(source, (x) => x == "Tom");
            Display(result);

            /* 修正以 Display() 顯示
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }//*/
            Console.ReadLine();

        }

        public static void Display(List<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


        public static bool SearchDavid(string value)
        { //委派方法
            return (value == "David"); 
        }

        public static bool SearchTom(string value)
        { //委派方法
            return (value == "Tom");
        }

    }

    public class MyCalss
    {

        /*
        public List<string> DoWhere(List<string> source, MyPredicate predicate)
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        */

        //Func
        public List<string> DoWhere(List<string> source, Func<string, bool> predicate)
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }

}
