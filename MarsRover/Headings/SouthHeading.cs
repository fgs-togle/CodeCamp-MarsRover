using MarsRover.Headings;

namespace MarsRover
{
    public class SouthHeading : IHeading
    {
        public IHeading TurnRight() => new WestHeading();

        public IHeading TurnLeft() => new EastHeading();

        public void MoveForward(Rover rover, Grid grid)
        {
            var currentY = rover.YCoordinate;
            rover.YCoordinate = (currentY > 0) ? currentY -= 1 : grid.GridHeight();
        }

        public void MoveBackward(Rover rover, Grid grid)
        {
            var currentY = rover.YCoordinate;
            rover.YCoordinate = (currentY < grid.GridHeight()) ? currentY += 1 : 0;
        }

        public string GetHeading() => HeadingNames.Headings.South.ToString();
    }
}
