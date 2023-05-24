using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WhereTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 場景1.過濾大於三的數字序列
        /// </summary>
        [TestMethod]
        public void GivenSequenceThenFindNumberBiggerThanThree()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var where = new MyWhere();
            var result = where.whereBiggerThanThree();

            result.Should().

        }
    }
}
