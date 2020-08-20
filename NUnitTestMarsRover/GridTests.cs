using NUnit.Framework;
using MarsRover;

namespace NUnitTestMarsRover
{
    public class GridTests
    {
        [Test]
        [TestCase(5, 5, 5, 5)]
        [TestCase(10, 5, 10, 5)]
        [TestCase(-20, 20, 20, 20)]
        public void Grid_GivenXYAndGridSize_ReturnsCorrectClassVariableAssignments(int gridX, int gridY, int resultXGrid, int resultYGrid)
        {
            var grid = new Grid(gridX, gridY);
            Assert.That(grid.GridWidth() == resultXGrid &&
                        grid.GridHeight() == resultYGrid);
        }
    }
}