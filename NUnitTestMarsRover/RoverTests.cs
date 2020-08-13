using NUnit.Framework;
using MarsRover;
using System.Collections.Generic;

namespace NUnitTestMarsRover
{
    public class RoverTests
    {
        private Grid _grid;
        private IEnumerable<Obstacle> _obstacles;
        private NorthHeading _northHeading;
        private SouthHeading _southHeading;
        private EastHeading _eastHeading;
        private WestHeading _westHeading;

        [SetUp]
        public void SetUp()
        {
            _grid = new Grid(5, 5);
            _obstacles = new List<Obstacle>();
            _northHeading = new NorthHeading();
            _southHeading = new SouthHeading();
            _eastHeading = new EastHeading();
            _westHeading = new WestHeading(); ;
        }

        [Test]
        [TestCase("fflffrbb", 5, 4, "South")]
        [TestCase("RFRFRFFRFF", 4, 3, "South")]
        [TestCase("blffflff", 0, 1, "North")]
        public void ExecuteCommands_GivenAListOfCommandsStartingInSouthDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
           var rover = new Rover(_grid, _southHeading, _obstacles);
            rover.XCoordinate = 3;
            rover.YCoordinate = 4;
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }


        [Test]
        [TestCase("fflffrbb", 1, 4, "North")]
        [TestCase("RFRFRFFRFF", 2, 5, "North")]
        [TestCase("blffflff", 0, 1, "South")]
        public void ExecuteCommands_GivenAListOfCommandsStartingInNorthDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
            var rover = new Rover(_grid, _northHeading, _obstacles);
            rover.XCoordinate = 3;
            rover.YCoordinate = 4;
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }


        [Test]
        [TestCase("fflffrbb", 3, 0, "East")]
        [TestCase("RFRFRFFRFF", 4, 5, "East")]
        [TestCase("blffflff", 0, 1, "West")]
        public void ExecuteCommands_GivenAListOfCommandsStartingInEastDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
            var rover = new Rover(_grid, _eastHeading, _obstacles);
            rover.XCoordinate = 3;
            rover.YCoordinate = 4;
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }

        [Test]
        [TestCase("fflffrbb", 3, 2, "West")]
        [TestCase("RFRFRFFRFF", 2, 3, "West")]
        [TestCase("blffflff", 0, 1, "East")]
        public void ExecuteCommands_GivenAListOfCommandsStartingInWestDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
            var rover = new Rover(_grid, _westHeading, _obstacles);
            rover.XCoordinate = 3;
            rover.YCoordinate = 4;
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }

        [Test]
        [TestCase("fflffrmm", 1, 0, "North")]
        [TestCase("RFRFRXRFF", 4, 5, "North")]
        [TestCase("blff01lff", 1, 1, "South")]
        public void ExecuteCommands_GivenAListOfCommandsWithInvalidCharactersStartingInNorthDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
            var rover = new Rover(_grid, _northHeading, _obstacles);
            rover.XCoordinate = 3;
            rover.YCoordinate = 4;
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoordinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }
    }
}
