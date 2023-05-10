using System;
using System.Collections.Generic;

namespace LastSkipTests
{
    internal static class MyLastSkip
    {
        internal static List<int> LastSkip(this List<int> sequence,int numberWantsToSkip)
        {
            var result = new List<int>();

            //1~6→#0,#1,#2,#3,#4,#5
            for(int i=0; i<= (sequence.Count - 1 - numberWantsToSkip); i++)
            {
                result.Add(sequence[i]);
            }
            return result;
        }
    }
}