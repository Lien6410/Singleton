using NUnit.Framework;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Tests
{
    [TestFixture()]
    public class ClassATests
    {
        [Test()]
        public void SingletonClassATest()
        {
            ClassA ins1 = ClassA.Instance;            

            ClassA ins2 = ClassA.Instance;

            Assert.AreEqual(ins1.Num, 0);
            Assert.AreEqual(ins1.Num, ins2.Num);

            ins1.Num = 123;

            Assert.AreEqual(ins2.Num, 123);

            ins2.Num = 456;

            Assert.AreEqual(ins1.Num, 456);
        }
    }
}