using MarsRover.Headings;

namespace MarsRover
{
    public class WestHeading : IHeading
    {
        public IHeading TurnRight() => new NorthHeading();

        public IHeading TurnLeft() => new SouthHeading();

        public void MoveForward(Rover rover, Grid grid)
        {
            var currentX = rover.XCoordinate;
            rover.XCoordinate = (currentX > 0) ? currentX -= 1 : grid.GridWidth();
        }

        public void MoveBackward(Rover rover, Grid grid)
        {
            var currentX = rover.XCoordinate;
            rover.XCoordinate = (currentX < grid.GridWidth()) ? currentX += 1 : 0;
        }

        public string GetHeading() => HeadingNames.Headings.West.ToString();
    }
}
