using System;
using NUnit.Framework;
using SandBox;

namespace MyTests
{
    public class FractionTests
    {
        [Test]
        public void CanCreate()
        {
            var maFraction = new Fraction(1, 2);
        }
        
        [Test]
        public void CanGetValue()
        {
            var maFraction = new Fraction(1, 2);

            var actual = maFraction.GetValue();
            const double expected = 0.5d;
            var difference = actual - expected;
            Assert.That(difference is < 0.00000001 and > -0.00000001);
        }
        
        [Test]
        public void CanNotDivideByZero()
        {
            Assert.Throws<ArgumentException>(() => new Fraction(1, 0));
        }
    }
}