using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassEx.Helpers
{
    internal static class MyHelper  
    {
        /*方法三：使用介面 + */
        public static IEnumerable<T> DoWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
            }

        }

        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> sources, Func<TSource, TResult> selector)
        {
            foreach (var item in sources) 
            {
                yield return selector.Invoke(item);
            }
        }


        



        /* 方法二：使用<泛型>
        public static List<T> DoWhere<T>(this List<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
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

        /* 方法一：使用 string 傳統
        public static List<string> DoWhere(this List<string> source, Func<string, bool> predicate)
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

    }
}
