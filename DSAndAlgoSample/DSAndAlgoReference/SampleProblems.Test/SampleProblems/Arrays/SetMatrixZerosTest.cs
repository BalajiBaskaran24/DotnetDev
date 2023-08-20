using DSAndAlgoReference.SampleProblems.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProblems.Test.SampleProblems.Arrays
{
    /// <summary>
    /// Xunit doesnt support 2D array as inline data
    /// </summary>
    public class SetMatrixZerosTest
    {
        [Theory]
        [InlineData(new int[12] { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 3, 4,
            new int[12] { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 })]
        [InlineData(new int[12] { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 4, 3,
            new int[12] { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 })]
        public void TestMatrixZeroBrute(int[] inputArray, int row, int col, int[] opArray)
        {
            // Arrange
            var calculator = new SetMatrixZeros();
            int[,] inp2D = new int[row, col];
            int[,] expOp2D = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    inp2D[i, j] = inputArray[i * col + j];
                    expOp2D[i, j] = opArray[i * col + j];
                }
            }


            // Act
            int[,] ObtainedOp = calculator.BruteForce(inp2D);

            // Assert
            Assert.Equal(ObtainedOp, expOp2D);
        }

        [Theory]
        [InlineData(new int[12] { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 3, 4,
            new int[12] { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 })]
        [InlineData(new int[12] { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 4, 3,
            new int[12] { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 })]
        public void TestMatrixZeroBetter(int[] inputArray, int row, int col, int[] opArray)
        {
            // Arrange
            var calculator = new SetMatrixZeros();
            int[,] inp2D = new int[row, col];
            int[,] expOp2D = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    inp2D[i, j] = inputArray[i * col + j];
                    expOp2D[i, j] = opArray[i * col + j];
                }
            }

            // Act
            int[,] ObtainedOp = calculator.BetterSolution(inp2D);

            // Assert
            Assert.Equal(ObtainedOp, expOp2D);
        }

    }
}
