using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathUtils;
using NUnit.Framework;
using Moq;

namespace MathUtils.Tests
{
	[TestFixture]
	public class CalculatorTests
	{
		private ILogger _logger;

		[SetUp]
		public void MockInitialize()
		{
			var mock = new Mock<ILogger>();

			mock.Setup(o => o.Log(It.IsAny<string>())).Callback<string>(Console.WriteLine);
			_logger = mock.Object;
		}
		
		//SumTestMethods
		[Test]
		[TestCase(2, 1, ExpectedResult = 3)]
		[TestCase(2, 5, ExpectedResult = 7)]
		public int TestSumWithinIntRange(int x, int y)
		{
			return new Calculator(_logger).Sum(x, y);
		}


		//DivideTestMethods
		[Test]
		//[ExpectedException(typeof(DivideByZeroException))]
		public void TestDivideMethodDivideByZero()
		{
			var calc = new Calculator(_logger);
			Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
		}

		[Test]
		[TestCase(10, 2, ExpectedResult = 5)]
		[TestCase(6, 3, ExpectedResult = 2)]
		public int TestDivideDivideTwoPositives(int x, int y)
		{
			return new Calculator(_logger).Divide(x, y);
		}

		[Test]
		[TestCase(6, -2, ExpectedResult = -3)]
		[TestCase(-10, 5, ExpectedResult = -2)]
		public int TestDividePositiveNegative(int x, int y)
		{
			return new Calculator(_logger).Divide(x, y);
		}

		[Test]
		[TestCase(-6, -2, ExpectedResult = 3)]
		[TestCase(-10, -5, ExpectedResult = 2)]
		public int TestDivideTwoNegatives(int x, int y)
		{
			return new Calculator(_logger).Divide(x, y);
		}

		//SubtractTestMethods
		[Test]
		[TestCase(5, 3, ExpectedResult = 2)]
		[TestCase(10, 4, ExpectedResult = 6)]
		public int TestSubtractionTwoPositives(int x, int y)
		{
			return new Calculator(_logger).Subtract(x, y);
		}

		[Test]
		[TestCase(-5, -3, ExpectedResult = -2)]
		[TestCase(-10, -4, ExpectedResult = -6)]
		public int TestSubtractionTwoNegatives(int x, int y)
		{
			return new Calculator(_logger).Subtract(x, y);
		}

		[Test]
		[TestCase(5, -3, ExpectedResult = 8)]
		[TestCase(3, -4, ExpectedResult = 7)]
		public int TestSubtractionPositiveNegative(int x, int y)
		{
			return new Calculator(_logger).Subtract(x, y);
		}

		//MultiplyTestMethods
		[Test]
		[TestCase(5, -3, ExpectedResult = -15)]
		[TestCase(10, -4, ExpectedResult = -40)]
		public int TestMultiplicationPositiveNegative(int x, int y)
		{
			return new Calculator(_logger).Multiply(x, y);
		}

		[Test]
		[TestCase(-2, -3, ExpectedResult = 6)]
		[TestCase(-5, -2, ExpectedResult = 10)]
		public int TestMultiplicationTwoNegatives(int x, int y)
		{
			return new Calculator(_logger).Multiply(x, y);
		}

		[Test]
		[TestCase(2, 3, ExpectedResult = 6)]
		[TestCase(5, 2, ExpectedResult = 10)]
		public int TestMultiplicationTwoPositives(int x, int y)
		{
			return new Calculator(_logger).Multiply(x, y);
		}

		[Test]
		[TestCase(5, 0, ExpectedResult = 0)]
		[TestCase(0, 4, ExpectedResult = 0)]
		public int TestMultiplicationWithZero(int x, int y)
		{
			return new Calculator(_logger).Multiply(x, y);
		}

		//ExpTestMethods
		[Test]
		[TestCase(5, 0, ExpectedResult = 1)]
		[TestCase(2, 0, ExpectedResult = 1)]
		public int TestExponentiationByZero(int x, int y)
		{
			return new Calculator(_logger).Exp(x, y);
		}

		[Test]
		[TestCase(2, 2, ExpectedResult = 4)]
		[TestCase(2, 3, ExpectedResult = 8)]
		public int TestExponentiationTwoPositives(int x, int y)
		{
			return new Calculator(_logger).Exp(x, y);
		}

		[Test]
		[TestCase(-1, 4, ExpectedResult = 1)]
		[TestCase(-2, 3, ExpectedResult = -8)]
		public int TestExponentiationNegativeBase(int x, int y)
		{
			return new Calculator(_logger).Exp(x, y);
		}

		[Test]
		[TestCase(5, -2, ExpectedResult = 0)]
		[TestCase(2, -3, ExpectedResult = 0)]
		public int TestExponentiationNegativePower(int x, int y)
		{
			return new Calculator(_logger).Exp(x, y);
		}

		//RootTestMethods
		[Test]
		[TestCase(9, 2, ExpectedResult = 3)]
		[TestCase(121, 2, ExpectedResult = 11)]
		public int TestRootTwoPositives(int x, int y)
		{
			return new Calculator(_logger).Root(x, y);
		}

		[Test]
		[TestCase(8, -3, ExpectedResult = 0)]	//0,5
		[TestCase(9, -2, ExpectedResult = 0)]	//0,(3)
		public int TestRootNegativeDegree(int x, int y)
		{
			return new Calculator(_logger).Root(x, y);
		}
	}
}







