using System;
using System.Collections.Generic;

namespace LastTakeTests
{
    internal class MyLastTake
    {
        internal List<int> LastTakeNumber(List<int> sequence,int number)//是不是不用Func?
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