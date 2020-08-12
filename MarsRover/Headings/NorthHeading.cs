
namespace MarsRover
{
    public class NorthHeading : IHeading
    {
        public IHeading TurnRight() => new EastHeading();

        public IHeading TurnLeft() => new WestHeading();

        public Grid MoveForward(Grid grid)
        {
            var y = grid.YCoordinate();
            y = (grid.YCoordinate() < grid.GridHeight()) ? y+=1 : 0;
            return grid = new Grid(grid.XCoordinate(), y, grid.GridWidth(), grid.GridHeight());
        }

        public Grid MoveBackward(Grid grid)
        {
            var y = grid.YCoordinate();
            y = (grid.YCoordinate() > 0) ? y-=1 : grid.GridHeight();
            return grid = new Grid(grid.XCoordinate(), y, grid.GridWidth(), grid.GridHeight());
        }

        public string GetHeading() => "North";
    }
}
