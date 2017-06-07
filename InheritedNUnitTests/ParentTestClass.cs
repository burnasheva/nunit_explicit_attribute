using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedNUnitTests
{
    [TestFixture]
    public class ParentTestClass
    {
        [Test]
        public void TestOutput()
        {
            Console.WriteLine("Hello, World");
            Assert.True(true);
        }
    }
}
