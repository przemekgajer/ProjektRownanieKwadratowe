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

    }
}