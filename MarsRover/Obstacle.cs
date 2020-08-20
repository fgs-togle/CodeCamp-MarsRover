
namespace MarsRover
{
    public class Obstacle
    {
        private int _obstacleXCoordinate;
        private int _obstacleYCoordinate;
        
        public Obstacle(int xCoordinate, int yCoordinate)
        {
            _obstacleXCoordinate = xCoordinate;
            _obstacleYCoordinate = yCoordinate;
        }

        public int ObstacleCoordinateX() => _obstacleXCoordinate;
        public int ObstacleCoordinateY() => _obstacleYCoordinate;
    }
}
