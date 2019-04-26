using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathUtils;
using NUnit.Framework;

namespace MathUtils.Tests
{
	[TestFixture]
	public class CalculatorTests
	{
		[Test]
		[TestCase(2, 1, ExpectedResult = 3)]
		[TestCase(2, 2, ExpectedResult = 4)]
		public int TestSumMethodWithinIntRange(int x, int y)
		{
			var calc = new Calculator();
			return calc.Sum(x, y);
			//var result = calc.Sum(2, 1);
			//Assert.AreEqual(3, result);

			//result = calc.Sum(2, 3);
			//Assert.AreEqual(5, result);
		}

		[Test]
		//[ExpectedException(typeof(DivideByZeroException))]
		public void TestDivideMethodDivideByZero()
		{
			var calc = new Calculator();
			Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
		}

		[Test]
		public void TestDivideDivideTwoPositives()
		{
			var calc = new Calculator();
			var result = calc.Divide(10, 2);
			Assert.AreEqual(5, result);

			result = calc.Divide(6, 3);
			Assert.AreEqual(2, result);
		}

		[Test]
		public void TestDividePositiveNegative()
		{
			var calc = new Calculator();
			var result = calc.Divide(6, -2);
			Assert.AreEqual(-3, result);

			result = calc.Divide(-10, 5);
			Assert.AreEqual(-2, result);
		}

		[Test]
		public void TestDivideTwoNegatives()
		{
			var calc = new Calculator();
			var result = calc.Divide(-6, -2);
			Assert.AreEqual(3, result);

			result = calc.Divide(-10, -5);
			Assert.AreEqual(2, result);
		}

		[Test]
		public void TestSubtractionTwoPositives()
		{
			var calc = new Calculator();
			var result = calc.Subtract(5, 3);
			Assert.AreEqual(2, result);

			result = calc.Subtract(10, 4);
			Assert.AreEqual(6, result);

		}
	}
}







