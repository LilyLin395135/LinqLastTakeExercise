using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LastTakeTests
{
    [TestClass]
    public class LastTaskTests
    {
        //���Ҥ@�B���X���X�̫�T�ӭ�
        [TestMethod]
        public void GivenSequenceTakeLastThree()
        {
            var sequence = new List<int>() { 1, 2, 3, 4, 5, 6};

            var lastTake = new MyLastTake();
            var result = lastTake.LastTakeThree(sequence);

            CollectionAssert.AreEqual(new List<int>{ 4, 5, 6 }, result);//�d�b�o�̡A�]�����G�O���X�A�n��CollectionAssert�ӫDAssert
        }
    }
}
