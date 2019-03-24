using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WindowsFormsApp1
{
    [TestFixture]
    class TestClass
    {
        Database ob = new Database();

        [Test]
        public void entry()
        {
            bool r = ob.Checkdb("Farhan","1234");
            Assert.IsTrue(r);
        }
        [Test]
        public void falseentry()
        {
            bool r = ob.Checkdb("Farhan", "4234");
            Assert.IsFalse(r);
        }
        [Test]
        public void nullentry()
        {
            Assert.Throws<NullReferenceException>(()=> ob.Checkdb("", "4234"));
        }
        [Test]
        public void nullpassentry()
        {
            Assert.Throws<NullReferenceException>(() => ob.Checkdb("Farhan", ""));
        }

        [Test]
        public void inserttest()
        {
            bool get = ob.inesertdb("labib", "1444", "3.5");
            Assert.IsTrue(get);
        }
        [Test]
        public void Namenullentry()
        {
            Assert.Throws<NullReferenceException>(() => ob.inesertdb("", "144", "3.5"));
        }
        [Test]
        public void Idnullentry()
        {
            Assert.Throws<NullReferenceException>(() => ob.inesertdb("bony", "", "3.5"));
        }
        [Test]
        public void CGPAnullentry()
        {
            Assert.Throws<NullReferenceException>(() => ob.inesertdb("bony", "144", ""));
        }


    }
}
