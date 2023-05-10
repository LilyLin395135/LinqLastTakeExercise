using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LastSkipTests
{
    [TestClass]
    public class LastSkipTests
    {
        //���Ҥ@�B���L�Ʀr���X�̫�T�ӭȡC
        [TestMethod]
        public void SkipLastThree()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var lastSkip = new MyLastSkip();
            var result = lastSkip.LastSkipThree(sequence);

            CollectionAssert.AreEqual(new List<int>() { 3,2,1}, result);//�d�b�o�̧ǦC�n�˹L��
        }
    }
}
