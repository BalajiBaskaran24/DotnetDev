using DSAndAlgoReference.SampleProblems.Arrays.OneDArray;

namespace SampleProblems.Test.SampleProblems.Arrays
{
    public class SmallestMissingNumberTest
    {


        /// <summary>
        /// {1,2,3} -> {} {1} {2} {3} {1,2} {2,3} {1,3} {1,2,3} Bitwise OR
        /// 1,2,3 output:4
        /// {1,4} -> 1, output:2
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="expectedOp"></param>
        [Theory]
        [InlineData(new int[] { 1, 3 }, 2)]
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
