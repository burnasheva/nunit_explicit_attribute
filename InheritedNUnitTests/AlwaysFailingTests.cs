using NUnit.Framework;

namespace InheritedNUnitTests
{
    [TestFixture]
    public class AlwaysFailingTests
    {
        [Test]
        public void AlwaysFailingTest()
        {
            Assert.True(false, "Should fail!");
        }
    }
}