using System;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestSum()
        {
            Assert.AreEqual(5, MathLibrary.Numbers.Sum(2, 3));
            Assert.AreEqual(12, MathLibrary.Numbers.Sum(5, 7));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.AreEqual(25, MathLibrary.Numbers.Multiplication(5, 5));
            Assert.AreEqual(40, MathLibrary.Numbers.Multiplication(5, 8));
        }

        [Test]
        public void TestDivision()
        {
            Assert.AreEqual(5, MathLibrary.Numbers.Division(15, 3));
            Assert.AreEqual(3, MathLibrary.Numbers.Division(24, 8));
        }

        [Test]
        public void TestSquare()
        {
            Assert.AreEqual(9, MathLibrary.Numbers.Square(3));
            Assert.AreEqual(25, MathLibrary.Numbers.Square(5));
        }

        [Test]
        public void TestPower()
        {
            Assert.AreEqual(8, MathLibrary.Numbers.Power(2, 3));
            Assert.AreEqual(256, MathLibrary.Numbers.Power(2, 8));
        }

        [Test]
        public void TestSqrt()
        {
            Assert.AreEqual(5, MathLibrary.Numbers.Sqrt(25));
            Assert.AreEqual(8, MathLibrary.Numbers.Sqrt(64));
        }

        [Test]
        public void TestPerimeterTriangle()
        {
            Assert.AreEqual(6, MathLibrary.Numbers.PerimeterTriangle(1, 2, 3));
            Assert.AreEqual(23, MathLibrary.Numbers.PerimeterTriangle(5, 8, 10));
        }

        [Test]
        public void TestAreaCircle()
        {
            Assert.AreEqual(314, MathLibrary.Numbers.AreaCircle(10));
            Assert.AreEqual(78.5, MathLibrary.Numbers.AreaCircle(5));
        }

        [Test]
        public void TestGravity()
        {
            Assert.AreEqual(98, MathLibrary.Numbers.Gravity(10));
            Assert.AreEqual(49, MathLibrary.Numbers.Gravity(5));
        }
    }
}