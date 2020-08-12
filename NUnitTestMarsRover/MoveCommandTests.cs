using NUnit.Framework;
using MarsRover;

namespace NUnitTestMarsRover
{
    class MoveCommandTests
    {
        // North Heading Tests
        [Test]
        public void MoveForward_GivenAMoveForwardFacingNorthFromZeroXZeroYPosition_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(1));
                Assert.That(rover.XCoordinate, Is.EqualTo(0));
            });
        }

        [Test]
        public void MoveForward_GivenAMoveForwardFacingNorthFromFiveXFiveYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(0));
                Assert.That(rover.XCoordinate, Is.EqualTo(5));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingNorthFromZeroXZeroYPositionAndAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(5));
                Assert.That(rover.XCoordinate, Is.EqualTo(0));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingNorthFromAFourXThreeYPosition_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(4, 3, 5, 5);
            var heading = new NorthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(2));
                Assert.That(rover.XCoordinate, Is.EqualTo(4));
            });
        }


        //South Heading Tests
        [Test]
        public void MoveForward_GivenAMoveForwardFacingSouthFromZeroXZeroYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(5));
                Assert.That(rover.XCoordinate, Is.EqualTo(0));
            });
        }

        [Test]
        public void MoveForward_GivenAMoveForwardFacingSouthFromFiveXFiveYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(4));
                Assert.That(rover.XCoordinate, Is.EqualTo(5));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingSouthFromFiveXFiveYPositionAndAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(0));
                Assert.That(rover.XCoordinate, Is.EqualTo(5));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingSouthFromAFourXThreeYPosition_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(4, 3, 5, 5);
            var heading = new SouthHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(4));
                Assert.That(rover.XCoordinate, Is.EqualTo(4));
            });
        }


        //West Heading Tests
        [Test]
        public void MoveForward_GivenAMoveForwardFacingWestFromZeroXZeroYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new WestHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(0));
                Assert.That(rover.XCoordinate, Is.EqualTo(5));
            });
        }

        [Test]
        public void MoveForward_GivenAMoveForwardFacingWestFromFiveXFiveYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new WestHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(5));
                Assert.That(rover.XCoordinate, Is.EqualTo(4));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingWestFromFiveXFiveYPositionAndAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new WestHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(5));
                Assert.That(rover.XCoordinate, Is.EqualTo(0));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingWestFromAFourXThreeYPosition_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(4, 3, 5, 5);
            var heading = new WestHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(3));
                Assert.That(rover.XCoordinate, Is.EqualTo(5));
            });
        }


        //East Heading Tests
        [Test]
        public void MoveForward_GivenAMoveForwardFacingEastFromZeroXZeroYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(0, 0, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(0));
                Assert.That(rover.XCoordinate, Is.EqualTo(1));
            });
        }

        [Test]
        public void MoveForward_GivenAMoveForwardFacingEastFromFiveXFiveYPositionOnAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveForward = new MoveForwardCommand(rover);
            moveForward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(5));
                Assert.That(rover.XCoordinate, Is.EqualTo(0));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingEastFromFiveXFiveYPositionAndAFiveByFiveGrid_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(5, 5, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(5));
                Assert.That(rover.XCoordinate, Is.EqualTo(4));
            });
        }


        [Test]
        public void MoveBackward_GivenAMoveBackwardFacingEastFromAFourXThreeYPosition_ReturnsCorrectCoordinate()
        {
            var grid = new Grid(4, 3, 5, 5);
            var heading = new EastHeading();
            var client = new RoverClient();
            var rover = new Rover(grid, heading);
            var moveBackward = new MoveBackwardCommand(rover);
            moveBackward.Execute();
            Assert.Multiple(() =>
            {
                Assert.That(rover.YCoodinate, Is.EqualTo(3));
                Assert.That(rover.XCoordinate, Is.EqualTo(3));
            });
        }
    }
}
