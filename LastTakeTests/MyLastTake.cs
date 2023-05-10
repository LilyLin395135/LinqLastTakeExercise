using System;
using System.Collections.Generic;

namespace LastTakeTests
{
    internal static class MyLastTake
    {
        internal static List<T> LastTake<T>( this List<T> resources,int number)//LastTake也要加<T>
        {
            var result = new List<T>();
            for(int i= (resources.Count-number); i< (resources.Count); i++)
            {
                result.Add(resources[i]);
            }
            return result;
        }
    }
}