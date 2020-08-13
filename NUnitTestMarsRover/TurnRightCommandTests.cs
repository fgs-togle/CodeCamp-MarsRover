using NUnit.Framework;
using MarsRover;
using System.Collections.Generic;
using MarsRover.Headings;

namespace NUnitTestMarsRover
{
    public class TurnRightCommandTests
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
        public void Execute_GivenNorthHeading_ReturnsEastHeading()
        {
            var rover = new Rover(_grid, _northHeading, _obstacles);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo(HeadingNames.Headings.East.ToString()));
        }

        [Test]
        public void Execute_GivenSouthHeading_ReturnsWestHeading()
        {
            var rover = new Rover(_grid, _southHeading, _obstacles);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo(HeadingNames.Headings.West.ToString()));
        }

        [Test]
        public void Execute_GivenEastHeading_ReturnsSouthHeading()
        {
            var rover = new Rover(_grid, _eastHeading, _obstacles);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo(HeadingNames.Headings.South.ToString()));
        }

        [Test]
        public void Execute_GivenWestHeading_ReturnsNorthHeading()
        {
            var rover = new Rover(_grid, _westHeading, _obstacles);
            var turnRight = new TurnRightCommand(rover);
            turnRight.Execute();
            Assert.That(rover.Direction, Is.EqualTo(HeadingNames.Headings.North.ToString()));
        }
    }
}
