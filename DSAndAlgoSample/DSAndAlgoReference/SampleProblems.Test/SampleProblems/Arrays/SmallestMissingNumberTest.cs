using DSAndAlgoReference.SampleProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
