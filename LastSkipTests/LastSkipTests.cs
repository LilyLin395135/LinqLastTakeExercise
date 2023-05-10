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

            CollectionAssert.AreEqual(new List<int>() { 3,2,1}, result);//卡在這裡序列要倒過來
        }
    }
}
