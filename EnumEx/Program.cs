using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEx
{
    internal class Program
    {
        static void Main(string[] args)
        { //列舉型別
            //DateTime dt = new DateTime.Now;
            var Week = DateTime.Now.DayOfWeek;
            Console.WriteLine($"ToDay= {Week.ToString()} is {(int)Week}");
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            
            MyWeekDays day = MyWeekDays.Sun;
            Console.WriteLine($"Today is {day}");
            if (day == MyWeekDays.Mon)
            {
                Console.WriteLine("Today is Monday");
            }
            else
            {
                Console.WriteLine("Today is not Monday");
            }
            //轉換回 int
            int i = (int)day;
            Console.WriteLine($"The value of {day} is {i}");

            Console.ReadLine();

        }
    }

    /// <summary>
    /// 自動從 0 開始
    /// </summary>
    public enum MyWeekDays
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat
    }
    /// <summary>
    /// 設定從 1 開始
    /// </summary>
    public enum BrowserTypes
    {
        IE = 1, Edge, FireFox, Chrom
    }
    /// <summary>
    /// 全部值都手動設定
    /// </summary>
    public enum SwitchTypes
    {
        On = 0, Off = 1
    }

}
