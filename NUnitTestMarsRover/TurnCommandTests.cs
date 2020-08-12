using NUnit.Framework;
using MarsRover;

namespace NUnitTestMarsRover
{
    class TurnCommandTests
    {
        [Test]
        public void TurnRight_GivenNorthHeading_ReturnsEastHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo("East"));
        }

        [Test]
        public void TurnLeft_GivenNorthHeading_ReturnsWestHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnLeft = new TurnLeftCommand(rover);
            turnLeft.Execute();
            Assert.That(rover.Direction, Is.EqualTo("West"));
        }

        [Test]
        public void TurnRight_GivenSouthHeading_ReturnsWestHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo("West"));
        }

        [Test]
        public void TurnLeft_GivenSouthHeading_ReturnsEastHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnLeft = new TurnLeftCommand(rover);
            turnLeft.Execute();
            Assert.That(rover.Direction, Is.EqualTo("East"));
        }

        [Test]
        public void TurnRight_GivenEastHeading_ReturnsSouthHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo("South"));
        }

        [Test]
        public void TurnLeft_GivenEastHeading_ReturnsNorthHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnLeft = new TurnLeftCommand(rover);
            turnLeft.Execute();
            Assert.That(rover.Direction, Is.EqualTo("North"));
        }

        [Test]
        public void TurnRight_GivenWestHeading_ReturnsNorthHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new WestHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo("North"));
        }

        [Test]
        public void TurnLeft_GivenWestHeading_ReturnsSouthHeading()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new WestHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var turnLeft = new TurnLeftCommand(rover);
            turnLeft.Execute();
            Assert.That(rover.Direction, Is.EqualTo("South"));
        }
    }
}
