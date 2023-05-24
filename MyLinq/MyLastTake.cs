using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLinq
{
    public static class MyLastTake
    {
        public static List<T> LastTake<T>(this IEnumerable<T> resources, int number)//LastTake也要加<T>
        {
            //var result = new List<T>();
            //for(int i= (resources.Count()-number); i< (resources.Count()); i++)//改成IEnumerable，無法直接用.Count要using LINQ
            //{
            //    result.Add(resources[i]);//這裡在IEnumerable無法使用，所以要寫下面的GetEnumerable...
            //}
            //return result;
            var result = new List<T>();
            var index = 0;

            var enumerator = resources.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (resources.Count() - number <= index)
                {
                    result.Add(enumerator.Current);
                }
                index++;
            }
            return result;
        }
    }
}