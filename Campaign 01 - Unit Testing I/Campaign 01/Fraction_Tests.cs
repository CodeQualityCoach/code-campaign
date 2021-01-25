using System;
using NUnit.Framework;

namespace Campaign_01
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class Fraction_Tests
    {
        [Test]
        public void Create_Fraction()
        {
            var sut = new Fraction(3, 4);

            Assert.AreEqual(3, sut.Numerator);
            Assert.AreEqual(4, sut.Denominator);
        }

        [Test]
        public void Create_Fraction_With_Zero_Denominator()
        {
            Assert.Throws<DivideByZeroException>(() => new Fraction(3, 0));
        }
    }
}