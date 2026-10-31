using Xunit;

namespace Exercise_7.UnutTests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData(49.99, false, 10)]
        [InlineData(49.99, true, 5)]
        [InlineData(50.01, false, 5)]
        [InlineData(50.01, true, 0)]
        public void CalculateShippingCost_OrderTotalIsNearThreshold_ReturnsCorrectCalculation(decimal order, bool premium, decimal expected)
        {
            var result = Exercise.CalculateShippingCost(order, premium);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.01, false, 10)]
        [InlineData(0.01, true, 5)]
        [InlineData(-0.01, false, 10)]
        [InlineData(-0.01, true, 5)]
        public void CalculateShippingCost_OrderTotalHasFractionalValues_ReturnsCorrectCalculation(decimal order, bool premium, decimal expected)
        {
            var result = Exercise.CalculateShippingCost(order, premium);
            Assert.Equal(expected, result);
        }
    }
}
