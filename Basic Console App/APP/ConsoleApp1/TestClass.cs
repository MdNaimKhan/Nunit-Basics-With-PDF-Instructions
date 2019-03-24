using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    class TestClass
    {
        Program ob = new Program();

        [Test]
        public void FisrtNumberMax()
        {
            int result = ob.Max("10", "5");
            Assert.AreEqual(10, result);
        }
        [Test]
        public void SecondNumberMax()
        {
            int result = ob.Max("8", "11");
            Assert.AreEqual(11, result);
        }
        [Test]
        public void FirstNumberBlank()
        {
            Assert.Throws<NullReferenceException>(() => ob.Max("", "5"));
        }

        [Test]
        public void CharacterCheck()
        {
            Assert.Throws<FormatException>(() => ob.Max("Abc", "5"));
        }
        [Test]
        public void OpenAccountTest1()
        {
            Assert.Throws<NullReferenceException>(() => ob.OpenAccount(""));

        }
        [Test]
        public void OpenAccountTest2()
        {
            int get = ob.OpenAccount("30");
            Assert.AreEqual(30, get);

        }
        [Test]
        public void LoopCodeTest()
        {
            int get = ob.LoopCode("3");
            Assert.AreEqual(7, get);
        }
        [Test]
        public void findStatusTest()
        {
            string back = ob.findStatus("A");
            Assert.AreEqual("Very Good  !!", back);
        }
    }
}
