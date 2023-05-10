using System;
using System.Collections.Generic;

namespace LastTakeTests
{
    internal static class MyLastTake
    {
        internal static List<int> LastTakeNumber( this List<int> sequence,int number)//+this參數就不用放sequence
        {
            var result = new List<int>();
            for(int i= (sequence.Count-number); i< (sequence.Count); i++)
            {
                result.Add(sequence[i]);
            }
            return result;
        }

        
    }
}