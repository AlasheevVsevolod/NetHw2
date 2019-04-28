using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils
{
	public interface ILogger
	{
		void Log(string text);
	}

	public class Logger : ILogger
	{
		public void Log(string text)
		{
			//log to file
		}
	}

	public class Calculator
	{
		public readonly ILogger _logger;

		public Calculator(ILogger logger)
		{
			_logger = logger;
		}

		public int Sum(int x, int y)
		{
			var result = x + y;
			_logger.Log($"{x} + {y} = {result}");
			return result;
		}

		public int Divide(int x, int y)
		{
			var result = x / y;
			_logger.Log($"{x} / {y} = {result}");
			return result;
		}

		public int Subtract(int x, int y)
		{
			var result = x - y;
			_logger.Log($"{x} - {y} = {result}");
			return result;
		}

		public int Multiply(int x, int y)
		{
			var result = x * y;
			_logger.Log($"{x} * {y} = {result}");
			return result;
		}

		public int Exp(int x, int y)
		{
			var result = (int)Math.Pow(x, y);
			_logger.Log($"{x} ^ {y} = {result}");
			return result;
		}

		public int Root(int x, int y)
		{
			var result = (int)Math.Pow(x, (double)1 / y);
			_logger.Log($"{y}th root of {x} = {result}");
			return result;
		}
	}
}
