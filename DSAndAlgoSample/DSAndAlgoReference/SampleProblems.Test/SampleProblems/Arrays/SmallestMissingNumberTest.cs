using DSAndAlgoReference.SampleProblems.Arrays.OneDArray;

namespace SampleProblems.Test.SampleProblems.Arrays
{
    public class SmallestMissingNumberTest
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, 4)]
        public void TestCalculateAlphaBeta(int[] inputArray, int expectedOp)
        {
            // Arrange
            var calculator = new SmallestMissingNumber();

            // Act
            int Output = calculator.FindSmallestMissingNumber(inputArray);

            // Assert
            Assert.Equal(Output, expectedOp);
        }
    }
}
