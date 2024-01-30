using Xunit;
using RownanieKwadratowe;

namespace RownanieKwadratowe.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData(1, -3, 2, 1, 2)]
        [InlineData(1, 2, 1, -1, null)]
        [InlineData(1, 0, 1, null, null)]
        public void Solve_ReturnsCorrectRoots(double a, double b, double c, double? expectedRoot1, double? expectedRoot2)
        {
            var result = Solver.Solve(a, b, c);
            Assert.Equal(expectedRoot1, result.Item1);
            Assert.Equal(expectedRoot2, result.Item2);
        }
    }
}