namespace Laba2.Tests
{
    public class BracketsCheckerTests
    {
        //[Fact]
        //public void FindMinimum()
        //{
        //    double[] mas = { 1, 2, 3, 4, 5 };
        //    double expected = 1;


        //    double actual = ExtensionMethods.FindMinimum(mas);

        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData(new double[] { 19, 34, 65, 1}, 1)]
        [InlineData(new double[] { -19, 34, 65, 1 }, -19)]

        public void MinimumTest(double[] mas, double expected)
        {
            double actual = ExtensionMethods.FindMinimum(mas);
            Assert.Equal(expected, actual);
        }
    }
}