using System;
using System.Collections.Generic;

namespace LastTakeTests
{
    internal class MyLastTake
    {
        internal List<int> LastTakeThree(List<int> sequence)
        {
            var result = new List<int>();
            for(int i= (sequence.Count-3); i< (sequence.Count); i++)
            {
                result.Add(sequence[i]);
            }
            return result;
        }
    }
}