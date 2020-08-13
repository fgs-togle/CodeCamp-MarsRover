using MarsRover.Headings;

namespace MarsRover
{
    public class EastHeading : IHeading
    {
        public IHeading TurnRight() => new SouthHeading();

        public IHeading TurnLeft() => new NorthHeading();

        public void MoveForward(Rover rover, Grid grid)
        {
            var currentX = rover.XCoordinate;
            rover.XCoordinate = (currentX < grid.GridWidth()) ? currentX += 1 : 0;
        }

        public void MoveBackward(Rover rover, Grid grid)
        {
            var currentX = rover.XCoordinate;
            rover.XCoordinate = (currentX > 0) ? currentX -= 1 : grid.GridWidth();
        }

        public string GetHeading() => HeadingNames.Headings.East.ToString();
    }
}
