using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LastTakeTests
{
    [TestClass]
    public class LastTaskTests
    {
        //�NTestMethod�̭���List����X�ӡA�g�����
        private readonly List<int> _sequence = new List<int>() { 1, 2, 3, 4, 5, 6 };
        
        //���Ҥ@�B���X���X�̫�T�ӭ�
        [TestMethod]
        public void GivenSequenceTakeLastThree()
        {
            var result = _sequence.LastTake(3);

            CollectionAssert.AreEqual(new List<int>{ 4, 5, 6 }, result);//�d�b�o�̡A�]�����G�O���X�A�n��CollectionAssert�ӫDAssert
        }

        //���ҤG�B���X���X�̫��ӭ�
        [TestMethod]
        public void GivenSequenceTakeLastTwo()
        {
            var result = _sequence.LastTake(2);

            CollectionAssert.AreEqual(new List<int> { 5, 6 }, result);
        }

        //���ҤT�B���X�r�����X�̫�|�ӭ�
        [TestMethod]
        public void GivenCharTakeLastFour()
        {
            var charactors = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };
            
            var result = charactors.LastTake(4);

            CollectionAssert.AreEqual(new List<char> { 'c', 'd', 'e', 'f' }, result);
        }
    }
}
