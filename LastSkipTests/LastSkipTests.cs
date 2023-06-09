using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLinq;
using System.Collections.Generic;

namespace LastSkipTests
{
    [TestClass]
    public class LastSkipTests
    {
        //集合抽出來寫成欄位
        private List<int>_sequence=new List<int>{ 1, 2, 3, 4, 5, 6 };

    //情境一、跳過數字集合最後三個值。
    [TestMethod]
        public void SkipLastThree()
        {
            var result = _sequence.LastSkip(3);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3 }, result);
        }

        //情境二、跳過數字集合最後兩個值。
        [TestMethod]
        public void SkipLastTwo()
        {
            var result = _sequence.LastSkip(2);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4 }, result);
        }

        //情境二、跳過字串集合最後四個值。
        [TestMethod]
        public void SkipLastFourWords()
        {
            var words = new List<string>() { "Bottle","Cell Phone" ,"Book","Bag","Ear Phone"};

            var result = words.LastSkip(4);

            CollectionAssert.AreEqual(new List<string>() { "Bottle" }, result);//卡在算錯剩下的word是哪些
        }
    }
}
