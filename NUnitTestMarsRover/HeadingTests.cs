using NUnit.Framework;
using MarsRover;

namespace NUnitTestMarsRover
{
    public class HeadingTests
    {
        [Test]
        public void NorthHeading_TurnRight_ReturnsEastHeading()
        {
            var heading = new NorthHeading();
            var newHeading = heading.TurnRight();
            Assert.IsInstanceOf<EastHeading>(newHeading);
        }
        
        [Test]
        public void NorthHeading_TurnLeft_ReturnsWestHeading()
        {
            var heading = new NorthHeading();
            var newHeading = heading.TurnLeft();
            Assert.IsInstanceOf<WestHeading>(newHeading);
        }

        [Test]
        public void SouthHeading_TurnRight_ReturnsWestHeading()
        {
            var heading = new SouthHeading();
            var newHeading = heading.TurnRight();
            Assert.IsInstanceOf<WestHeading>(newHeading);
        }

        [Test]
        public void SouthHeading_TurnLeft_ReturnsEastHeading()
        {
            var heading = new SouthHeading();
            var newHeading = heading.TurnLeft();
            Assert.IsInstanceOf<EastHeading>(newHeading);
        }

        [Test]
        public void EastHeading_TurnLeft_ReturnsNorthHeading()
        {
            var heading = new EastHeading();
            var newHeading = heading.TurnLeft();
            Assert.IsInstanceOf<NorthHeading>(newHeading);
        }

        [Test]
        public void EastHeading_TurnRight_ReturnsSouthHeading()
        {
            var heading = new EastHeading();
            var newHeading = heading.TurnRight();
            Assert.IsInstanceOf<SouthHeading>(newHeading);
        }

        [Test]
        public void WestHeading_TurnLeft_ReturnsSouthHeading()
        {
            var heading = new WestHeading();
            var newHeading = heading.TurnLeft();
            Assert.IsInstanceOf<SouthHeading>(newHeading);
        }

        [Test]
        public void WestHeading_TurnRight_ReturnsNorthHeading()
        {
            var heading = new WestHeading();
            var newHeading = heading.TurnRight();
            Assert.IsInstanceOf<NorthHeading>(newHeading);
        }
    }
}
