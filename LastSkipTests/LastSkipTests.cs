using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LastSkipTests
{
    [TestClass]
    public class LastSkipTests
    {
        //情境一、跳過數字集合最後三個值。
        [TestMethod]
        public void SkipLastThree()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var lastSkip = new MyLastSkip();
            var result = lastSkip.LastSkipThree(sequence);

            CollectionAssert.AreEqual(new List<int>() { 1,2,3}, result);//改成正常順序
        }

        //情境二、跳過數字集合最後兩個值。
        [TestMethod]
        public void SkipLastTwo()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var lastSkip = new MyLastSkip();
            var result = lastSkip.LastSkipTwo(sequence);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4 }, result);//改成正常順序
        }
    }
}
