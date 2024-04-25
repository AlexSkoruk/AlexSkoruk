using Lab2;


namespace Lab2.Test
{
    public class AlgorithmTests
    {
		internal bool IsEquivalent(double expected, double actual, double calcError)
		{
			return (expected <= actual + calcError) && (expected >= actual - calcError);
		}

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5}, 1)]
        [InlineData(new double[] { -1, 2, 3, 4, -5}, -5)]
        [InlineData(new double[] { 10, -10.000001, -10, -1, 100.2}, -10.000001)]
        [InlineData(new double[] { -10e-5, -0.000011 }, -10e-5)]
        [InlineData(new double[] { 1}, 1)]
        public void FindMinimumTheory(in IEnumerable<double> inputSequence, double expected)
        {
            double actual = Algorithm.FindMinimum(inputSequence);
            Assert.True(IsEquivalent(expected, actual, 1e-15));
        }

		[Theory]
		[InlineData(new double[] { 1, 2, 3, 4, 5 }, 5)]
		[InlineData(new double[] { -1, 2, 3, 4, -5 }, 4)]
		[InlineData(new double[] { 10, -10.000001, -10, -1, 100.2 }, 100.2)]
		[InlineData(new double[] { -10e-5, -0.000011 }, -1.1e-5)]
		[InlineData(new double[] { 1 }, 1)]
		public void FindMaximumTheory(in IEnumerable<double> inputSequence, double expected)
        {
			double actual = Algorithm.FindMaximum(inputSequence);
			Assert.True(IsEquivalent(expected, actual, 1e-15));
		}

		[Theory]
		[InlineData(new double[] { 1, 2, 3, 4, 5 }, 3)]
		[InlineData(new double[] { -1, 2, 3, 4, -5 }, 0.6)]
		[InlineData(new double[] { 10, -10.000001, -10, -1, 100.2 }, 17.8399998)]
		[InlineData(new double[] { -10e-5, -0.000011 }, -5.55e-5)]
		[InlineData(new double[] { 1 }, 1)]
		public void FindAverageTheory(in IEnumerable<double> inputSequence, double expected)
		{
			double actual = Algorithm.FindAverage(inputSequence);
			Assert.True(IsEquivalent(expected, actual, 1e-15));
		}

		[Theory]
		[InlineData(new double[] { 1, 2, 3, 4, 5 }, 3)]
		[InlineData(new double[] { -1, 2, 3, 4, -5 }, 2)]
		[InlineData(new double[] { 10, -10.000001, -10, -1, 100.2 }, -1)]
		[InlineData(new double[] { -10e-5, -0.000011 }, -5.55e-5)]
		[InlineData(new double[] { 1 }, 1)]
		public void FindMedianTheory(in IEnumerable<double> inputSequence, double expected)
		{
			double actual = Algorithm.FindMedian(inputSequence);
			Assert.True(IsEquivalent(expected, actual, 1e-15));
		}

		[Theory]
		[InlineData(new double[] { 1, 2, 3, 4, 5 }, 2.605171085)]
		[InlineData(new double[] {10, 7, 23.44, 4, 5 }, 8.002342378)]
		[InlineData(new double[] {7,7,7,7,7 }, 7)]
		[InlineData(new double[] {11,11, 20, 15, 20 }, 14.865767088)]
		[InlineData(new double[] {1,2,12.96,15,20}, 6)]
		public void FindGeometricAverageTheory(in IEnumerable<double> inputSequence, double expected)
		{
			double actual = Algorithm.FindGeometricAverage(inputSequence);
			Assert.True(IsEquivalent(expected, actual, 1e-9));
		}
	}

	public class CalculatorTests
	{

		[Theory]
		[InlineData("1-(2+ 3)", -4)]
		[InlineData("1+-2", -1)]
		[InlineData("20 + (3 - (6/3) * (12-(6-(2+5))))", -3)]
		[InlineData("-1--2", 1)]
		[InlineData("1,25657 - 3,75652", -2.49995)]
		[InlineData("1111,1111112345678 - 1111,111111234567", 1E-12)]
		public void SuccsessfulCalculatorTest(string expression, double expected) 
		{ 
			double actual = Calculator.Calculate(expression);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("")]
		[InlineData("1-")]
		[InlineData("20/(30-40+10)")]
		[InlineData("20/((30-40+10)*0)")]
		public void ErrorCalculatorTest(string incorrectExpression)
		{
			Assert.Throws<Exception>(() => { double res = Calculator.Calculate(incorrectExpression); });
		}

	}
}