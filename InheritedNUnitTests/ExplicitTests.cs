using System;
using NUnit.Framework;

namespace InheritedNUnitTests
{
    [TestFixture]
    [Explicit]
    public class ExplicitTests
    {
        [Test]
        public void ExplicitTest()
        {
            Console.WriteLine("Explicit Test is called");
            Assert.True(true);
        }
    }
}