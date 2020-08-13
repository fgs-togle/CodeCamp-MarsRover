using NUnit.Framework;
using MarsRover;
using System.Collections.Generic;

namespace NUnitTestMarsRover
{
    public class MoveForwardCommandTests
    {
        private Grid _grid;
        private NorthHeading _northHeading;
        private SouthHeading _southHeading;
        private EastHeading _eastHeading;
        private WestHeading _westHeading;
        private IEnumerable<Obstacle> _obstacles;

        [SetUp]
        public void SetUp()
        {
            _northHeading = new NorthHeading();
            _southHeading = new SouthHeading();
            _eastHeading = new EastHeading();
            _westHeading = new WestHeading();
            _grid = new Grid(5, 5);
            _obstacles = new List<Obstacle>();
        }

        [Test]
        [TestCase(0, 0, 0, 1)]
        [TestCase(5, 5, 5, 0)]
        [TestCase(3, 3, 3, 4)]
        [TestCase(1, 2, 1, 3)]
        public void Execute_FacingNorthOnFiveByFiveGrid_ReturnsCorrectCoordinate(int currentX, int currentY, int expectedX, int expectedY)
        {
            var rover = new Rover(_grid, _northHeading, _obstacles);
            rover.XCoordinate = currentX;
            rover.YCoordinate = currentY;
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedY));
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedX));
            });
        }

        [Test]
        [TestCase(0, 0, 0, 5)]
        [TestCase(5, 5, 5, 4)]
        [TestCase(3, 3, 3, 2)]
        [TestCase(1, 2, 1, 1)]
        public void Execute_FacingSouthOnFiveByFiveGrid_ReturnsCorrectCoordinate(int currentX, int currentY, int expectedX, int expectedY)
        {
            var rover = new Rover(_grid, _southHeading, _obstacles);
            rover.XCoordinate = currentX;
            rover.YCoordinate = currentY;
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedY));
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedX));
            });
        }

        [Test]
        [TestCase(0, 0, 1, 0)]
        [TestCase(5, 5, 0, 5)]
        [TestCase(3, 3, 4, 3)]
        [TestCase(1, 2, 2, 2)]
        public void Execute_FacingEastOnFiveByFiveGrid_ReturnsCorrectCoordinate(int currentX, int currentY, int expectedX, int expectedY)
        {
            var rover = new Rover(_grid, _eastHeading, _obstacles);
            rover.XCoordinate = currentX;
            rover.YCoordinate = currentY;
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedY));
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedX));
            });
        }

        [Test]
        [TestCase(0, 0, 5, 0)]
        [TestCase(5, 5, 4, 5)]
        [TestCase(3, 3, 2, 3)]
        [TestCase(1, 2, 0, 2)]
        public void Execute_FacingWestOnFiveByFiveGrid_ReturnsCorrectCoordinate(int currentX, int currentY, int expectedX, int expectedY)
        {
            var rover = new Rover(_grid, _westHeading, _obstacles);
            rover.XCoordinate = currentX;
            rover.YCoordinate = currentY;
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedY));
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedX));
            });
        }
    }
}
