using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Add_Add3and4_returns7()
        {
            var uut = new Calculator();

            Assert.That(uut.add(3,4), Is.EqualTo(7));
        }

        [Test]
        public void Minus_minus6and2_returns4()
        {
            var uut = new Calculator();
            
            Assert.That(uut.subtract(6,4), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_Multiply3and5_returns15()
        {
            var uut = new Calculator();
            
            Assert.That(uut.multiply(3,5), Is.EqualTo(15));
     
        }

        [Test]
        public void Power_Pow2exp4_returns16()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(2,4), Is.EqualTo(16));
        }
    }
}
