using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class Rover
    {
        private Grid _grid;
        private IHeading _heading;
        private IEnumerable<Obstacle> _obstacles;
        private bool _obstacleDetected;
        private int _obstacleDetectedCoordinateX;
        private int _obstacleDetectedCoordinateY;

        public Rover(Grid grid, IHeading heading, IEnumerable<Obstacle> Obstacles)
        {
            _grid = grid;
            _heading = heading;
            _obstacles = Obstacles;
            _obstacleDetected = false;
        }

        public void TurnLeft() => _heading = _heading.TurnLeft();

        public void TurnRight() => _heading = _heading.TurnRight();

        public void MoveForward() => _heading.MoveForward(this, _grid);

        public void MoveBackward() => _heading.MoveBackward(this, _grid);

        public void InvalidCommand() { }

        public string Direction() => _heading.GetHeading();

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public bool ObstacleDetected() => _obstacleDetected;

        public int ObstacleDetectedXCoordinate() => _obstacleDetectedCoordinateX;

        public int ObstacleDetectedYCoordinate() => _obstacleDetectedCoordinateY;

        public void ExecuteCommands(string commands)
        {
            foreach (var letter in commands)
            {
                var commandInput = new InputCommands(letter.ToString());
                var commandFactory = commandInput.ReturnCommand();
                var command = commandFactory(this);
                var previousLocation = _grid;
                command.Execute();

                if (_obstacleDetected = ObstacleFound(XCoordinate, YCoordinate) == true) 
                {
                    _obstacleDetectedCoordinateX = XCoordinate;
                    _obstacleDetectedCoordinateY = YCoordinate;
                    _grid = previousLocation;
                    break; 
                }
            }
        }

        private bool ObstacleFound(int xCoordinate, int yCoordinate) => 
            _obstacles.Any(obstacle => obstacle.ObstacleCoordinateX() == xCoordinate && obstacle.ObstacleCoordinateY() == yCoordinate);
    }
}
