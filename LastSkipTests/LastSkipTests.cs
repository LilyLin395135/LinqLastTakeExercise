using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLinq;
using System.Collections.Generic;

namespace LastSkipTests
{
    [TestClass]
    public class LastSkipTests
    {
        //���X��X�Ӽg�����
        private List<int>_sequence=new List<int>{ 1, 2, 3, 4, 5, 6 };

    //���Ҥ@�B���L�Ʀr���X�̫�T�ӭȡC
    [TestMethod]
        public void SkipLastThree()
        {
            var result = _sequence.LastSkip(3);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3 }, result);
        }

        //���ҤG�B���L�Ʀr���X�̫��ӭȡC
        [TestMethod]
        public void SkipLastTwo()
        {
            var result = _sequence.LastSkip(2);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4 }, result);
        }

        //���ҤG�B���L�r�궰�X�̫�|�ӭȡC
        [TestMethod]
        public void SkipLastFourWords()
        {
            var words = new List<string>() { "Bottle","Cell Phone" ,"Book","Bag","Ear Phone"};

            var result = words.LastSkip(4);

            CollectionAssert.AreEqual(new List<string>() { "Bottle" }, result);//�d�b����ѤU��word�O����
        }
    }
}
