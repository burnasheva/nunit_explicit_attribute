using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedNUnitTests
{
    class ChildTests : ParentTestClass
    {
        [Test]
        public void SecondTest()
        {
            Console.WriteLine("Second Hello, World");
            Assert.True(true);
        }
    }
}
