using NUnit.Framework;

namespace DataDrivenTests
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(string))]
    class GenericTestFixture<T>
    {
        [Test]
        public void TestType()
        {
            Assert.Pass($"the generic test type is {typeof(T)}");
        }
    }
}
