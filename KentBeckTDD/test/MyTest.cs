using KentBeckTDD.src;
using NUnit.Framework;

namespace KentBeckTDD.test
{
    [TestFixture]

    class MyTest
    {
        [TestCase]
        public void multiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(10, product.amount);
            product = five.times(3);
            Assert.AreEqual(15, product.amount);
        }

        [TestCase]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).IsEaqualTo(new Dollar(5)));
            Assert.IsFalse(new Dollar(6).IsEaqualTo(new Dollar(5)));
        }
    }
}
