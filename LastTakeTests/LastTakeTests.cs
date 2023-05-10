using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LastTakeTests
{
    [TestClass]
    public class LastTaskTests
    {
        //將TestMethod裡面的List都抽出來，寫成欄位
        private readonly List<int> _sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };
        
        //情境一、取出集合最後三個值
        [TestMethod]
        public void GivenSequenceTakeLastThree()
        {
            var result = _sequence.LastTake(3);

            CollectionAssert.AreEqual(new List<int>{ 4, 5, 6 }, result);//卡在這裡，因為結果是集合，要用CollectionAssert而非Assert
        }

        //情境二、取出集合最後兩個值
        [TestMethod]
        public void GivenSequenceTakeLastTwo()
        {
            var result = _sequence.LastTake(2);

            CollectionAssert.AreEqual(new List<int> { 5, 6 }, result);
        }

        //情境三、取出字元集合最後四個值
        [TestMethod]
        public void GivenCharTakeLastFour()
        {
            var charactors = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };
            
            var result = charactors.LastTake(4);

            CollectionAssert.AreEqual(new List<char> { 'c', 'd', 'e', 'f' }, result);
        }
    }
}
