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
    public class ClassETests
    {
        [Test()]
        public void SingletonClassETest()
        {
            ClassE ins1 = ClassE.Instance;

            ClassE ins2 = ClassE.Instance;

            Assert.AreEqual(ins1.Num, 0);
            Assert.AreEqual(ins1.Num, ins2.Num);

            ins1.Num = 123;

            Assert.AreEqual(ins2.Num, 123);

            ins2.Num = 456;

            Assert.AreEqual(ins1.Num, 456);
        }
    }
}