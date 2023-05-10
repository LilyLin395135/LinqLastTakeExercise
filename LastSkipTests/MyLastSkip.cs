using System;
using System.Collections.Generic;

namespace LastSkipTests
{
    internal static class MyLastSkip
    {
        internal static List<T> LastSkip<T>(this List<T> resources,int numberWantsToSkip)
        {
            var result = new List<T>();

            for(int i=0; i<= (resources.Count - 1 - numberWantsToSkip); i++)
            {
                result.Add(resources[i]);
            }
            return result;
        }

    }
}