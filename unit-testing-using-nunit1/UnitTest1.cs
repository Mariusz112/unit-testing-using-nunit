using NUnit.Framework;
using NUnit.Framework.Internal;

namespace unit_testing_using_nunit1
{
    [TestFixture]
    public class PrimeService_IsPrime
    {
        private Test _test;

        [SetUp]
        public void SetUp()
        {
            _test = new Test();
        }

        [TestCase(1)]
        [TestCase(12)]
        [TestCase(88)]
        public void IsPrimeFalse(int value)
        {
            var result = _test.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestCase(2)]
        [TestCase(7)]
        [TestCase(83)]
        public void IsPrimeTrue(int value)
        {
            var result = _test.IsPrime(value);

            Assert.IsTrue(result, $"{value} should be prime");
        }
    }
}