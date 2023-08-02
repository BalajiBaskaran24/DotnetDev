namespace UnitTestRepo;
public partial class CalculatorTests
{
    // This static property returns the data for the test
    public static IEnumerable<object[]> AdditionData =>
        new List<object[]>
        {
            new object[] { 1, 2, 3 },
            new object[] { -1, -1, -2 },
            new object[] { 100, 100, 200 }
        };
}