
namespace MarsRover
{
    public class WestHeading : IHeading
    {
        public IHeading TurnRight() => new NorthHeading();

        public IHeading TurnLeft() => new SouthHeading();

        public Grid MoveForward(Grid grid)
        {
            var x = grid.XCoordinate();
            x = (grid.XCoordinate() > 0) ? x -= 1 : grid.GridWidth();
            return grid = new Grid(x, grid.YCoordinate(), grid.GridWidth(), grid.GridHeight());
        }

        public Grid MoveBackward(Grid grid)
        {
            var x = grid.XCoordinate();
            x = (grid.XCoordinate() < grid.GridWidth()) ? x += 1 : 0;
            return grid = new Grid(x, grid.YCoordinate(), grid.GridWidth(), grid.GridHeight());
        }

        public string GetHeading() => "West";
    }
}
