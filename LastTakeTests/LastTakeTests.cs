using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LastTakeTests
{
    [TestClass]
    public class LastTaskTests
    {
        //情境一、取出集合最後三個值
        [TestMethod]
        public void GivenSequenceTakeLastThree()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6};

            var lastTake = new MyLastTake();
            var result = lastTake.LastTakeNumber(sequence,3);

            CollectionAssert.AreEqual(new List<int>{ 4, 5, 6 }, result);//卡在這裡，因為結果是集合，要用CollectionAssert而非Assert
        }

        //情境二、取出集合最後兩個值
        [TestMethod]
        public void GivenSequenceTakeLastTwo()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var lastTake = new MyLastTake();
            var result = lastTake.LastTakeNumber(sequence,2);

            CollectionAssert.AreEqual(new List<int> { 5, 6 }, result);
        }
    }
}
