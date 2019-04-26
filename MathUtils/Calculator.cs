using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils
{
	public class Logger
	{
		public void Log(string text)
		{ 
		}
	}

	public class Calculator
	{
		public readonly Logger _logger;

		public Calculator(Logger logger)
		{
			_logger = logger;
		}

		public int Sum(int x, int y)
		{
			return x + y;
		}

		public int Divide(int x, int y)
		{
			return x / y;
		}

		public int Subtract(int x, int y)
		{
			return x - y;
		}
	}
}
