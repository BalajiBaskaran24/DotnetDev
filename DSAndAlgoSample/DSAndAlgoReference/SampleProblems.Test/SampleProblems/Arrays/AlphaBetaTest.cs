using DSAndAlgoReference.SampleProblems.Arrays.OneDArray;

namespace SampleProblems.Test.SampleProblems.Arrays;

public class AlphaBetaTest
{

    [Theory]
    [InlineData(new int[] { 1 }, 1, 0)]
    [InlineData(new int[] { 3, 3, 3, 2, 2, 1, 1, 1 }, 2, 0)]
    [InlineData(new int[] { 3, 3, 2, 2, 1, 5, 5, 5, 5, 5 }, 3, 2)]
    [InlineData(new int[] { 1, 1, 2, 2 }, 1, 1)]
    [InlineData(new int[] { 1, 0, 1, 0 }, 2, 0)]
    [InlineData(new int[] { 4, 4, 4, 1, 1, 3 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 4, 4, 4, 4, 2, 2, 2 }, 3, 3)]
    public void TestCalculateAlphaBeta(int[] inputArray, int expectedAlpha, int expectedBeta)
    {
        // Arrange
        var calculator = new AlphaBeta();
        var input = new List<int>(inputArray);

        // Act
        var (Alpha, Beta) = calculator.Solution(input);

        // Assert
        Assert.Equal(expectedAlpha, Alpha);
        Assert.Equal(expected: expectedBeta, Beta);
    }
}
