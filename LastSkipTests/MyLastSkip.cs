using System;
using System.Collections.Generic;

namespace LastSkipTests
{
    internal class MyLastSkip
    {
        internal List<int> LastSkipThree(List<int> sequence)
        {
            var result = new List<int>();

            //1~6→#0,#1,#2,#3,#4,#5
            for(int i=0; i<= sequence.Count - 1 - 3; i++)
            {
                result.Add(sequence[i]);
            }
            return result;
        }
    }
}