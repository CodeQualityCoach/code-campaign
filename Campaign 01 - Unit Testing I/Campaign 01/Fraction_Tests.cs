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
            Assert.Throws<DivideByZeroException>(() => new Fraction(3, 0), "Denominator in a fraction cannot be zero.");
        }

        [Test]
        public void Multiply_Fraction()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(3, 5);

            var sut = a * b;

            Assert.AreEqual(6, sut.Numerator);
            Assert.AreEqual(15, sut.Denominator);
        }

        [Test]
        public void Add_Fraction()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(3, 5);

            var sut = a + b;

            Assert.AreEqual(19, sut.Numerator);
            Assert.AreEqual(15, sut.Denominator);
        }
    }
}