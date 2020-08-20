using MarsRover.Headings;

namespace MarsRover
{
    public class NorthHeading : IHeading
    {
        public IHeading TurnRight() => new EastHeading();

        public IHeading TurnLeft() => new WestHeading();

        public void MoveForward(Rover rover, Grid grid)
        {
            var currentY = rover.YCoordinate;
            rover.YCoordinate = (currentY < grid.GridHeight()) ? currentY += 1 : 0;
        }

        public void MoveBackward(Rover rover, Grid grid)
        {
            var currentY = rover.YCoordinate;
            rover.YCoordinate = (currentY > 0) ? currentY -= 1 : grid.GridHeight();
        }

        public string GetHeading() => HeadingNames.Headings.North.ToString();
    }
}
