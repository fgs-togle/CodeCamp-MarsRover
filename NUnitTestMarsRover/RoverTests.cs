using NUnit.Framework;
using MarsRover;

namespace NUnitTestMarsRover
{
    public class RoverTests
    {
        [Test]
        public void Rover_GivenCreateRoverConstructor_ReturnsThreeXThreeYCoordinatesWithTenBy5GridAndSouthHeading()
        {
            var grid = new Grid(3, 3, 10, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            Rover rover = new Rover(grid, heading);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(3));
                Assert.That(rover.YCoodinate, Is.EqualTo(3));
                Assert.That(rover.GridWidth, Is.EqualTo(10));
                Assert.That(rover.GridHeight, Is.EqualTo(5));
                Assert.That(rover.Direction, Is.EqualTo("South"));
            });
        }


        [Test]
        [TestCase("fflffrbb", 5, 4, "South")]
        [TestCase("RFRFRFFRFF", 4, 3, "South")]
        [TestCase("blffflff", 0, 1, "North")]
        public void ExecuteCommands_GivenAListOfCommandsStartingInSouthDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
            var grid = new Grid(3, 4, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            Rover rover = new Rover(grid, heading);
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoodinate, Is.EqualTo(expectedYCoordinates));
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
            var grid = new Grid(3, 4, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            Rover rover = new Rover(grid, heading);
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoodinate, Is.EqualTo(expectedYCoordinates));
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
            var grid = new Grid(3, 4, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            Rover rover = new Rover(grid, heading);
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoodinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }


        [Test]
        [TestCase("fflffrbb", 3, 2, "West", 4, 8)]
        [TestCase("RFRFRFFRFF", 2, 3, "West", 4, 8)]
        [TestCase("blffflff", 1, 1, "East", 4, 8)]
        public void ExecuteCommands_GivenAListOfCommandsStartingInWestDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection, 
            int expectedGridWidth, int expectedGridHeight)
        {
            var grid = new Grid(3, 4, 4, 8);
            var heading = new WestHeading();
            var client = new RoverClient();
            Rover rover = new Rover(grid, heading);
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoodinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
                Assert.That(rover.GridWidth, Is.EqualTo(expectedGridWidth));
                Assert.That(rover.GridHeight, Is.EqualTo(expectedGridHeight));
            });
        }


        [Test]
        [TestCase("fflffrmm", 1, 0, "North")]
        [TestCase("RFRFRXRFF", 4, 5, "North")]
        [TestCase("blff01lff", 1, 1, "South")]
        public void ExecuteCommands_GivenAListOfCommandsWithInvalidCharactersStartingInNorthDirection_ReturnsCorrectCoordinatesAndCurrentHeading(
            string commands, int expectedXCoodinates, int expectedYCoordinates, string expectedDirection)
        {
            var grid = new Grid(3, 4, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            Rover rover = new Rover(grid, heading);
            rover.ExecuteCommands(commands);
            Assert.Multiple(() =>
            {
                Assert.That(rover.XCoordinate, Is.EqualTo(expectedXCoodinates));
                Assert.That(rover.YCoodinate, Is.EqualTo(expectedYCoordinates));
                Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
            });
        }
    }
}
