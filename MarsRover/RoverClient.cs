using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class RoverClient
    {
        private Grid _grid;
        private IHeading _heading;
        private IEnumerable<Obstacle> _obstacles;
        private Rover _rover;


        public RoverClient()
        {
            _grid = new Grid(5, 5);
            _heading = new NorthHeading();
            _obstacles = CreateObstacles(3);
            _rover = new Rover(_grid, _heading, _obstacles);
            _rover.XCoordinate = 3;
            _rover.YCoordinate = 3;
        }

        public void RoverInstructions()
        {
            var commands = string.Empty;
            DisplayInstructions();
            
            while(!commands.Equals("X"))
            {
                Console.WriteLine($"Your current position on the surface grid is {_rover.XCoordinate}, {_rover.YCoordinate} and the Rover is facing {_rover.Direction()}.\n");
                Console.WriteLine("Please enter your rover commands: ");
                commands = Console.ReadLine().ToUpper().Replace(" ", "");
                _rover.ExecuteCommands(commands);

                if (_rover.ObstacleDetected()) 
                { Console.WriteLine($"An obstacle was encountered at {_rover.ObstacleDetectedXCoordinate()}, {_rover.ObstacleDetectedYCoordinate()} " +
                                        $"and the rover was stopped to avoid a collision.\n"); 
                }
            }
        }

        private IEnumerable<Obstacle> CreateObstacles(int numberOfObstacles)
        {
            var obstacles = new List<Obstacle>();
            var random = new Random();

            for (var i = 0; i < numberOfObstacles; i++)
            {
                var obstacleXCoordinate = random.Next(0, _grid.GridWidth());
                var obstacleYCoordinate = random.Next(0, _grid.GridHeight());

                if (!(ObstacleSameAsStartingPoint(obstacleXCoordinate, obstacleYCoordinate)))
                {
                    yield return new Obstacle(obstacleXCoordinate, obstacleYCoordinate);
                }
            }
        }

        private bool ObstacleSameAsStartingPoint(int x, int y) => (x == _rover.XCoordinate && y == _rover.YCoordinate);

        private void DisplayInstructions()
        {
            Console.WriteLine("****Mars Rover Controller****\n");
            Console.WriteLine("Use the following letters to write a set of commands for the Rover to follow.  Invalid commands will be ignored:");
            Console.WriteLine("         F = Forward     B = Backward");
            Console.WriteLine("         L = Turn Left   R = Turn Right");
            Console.WriteLine("            X = Exit the Controller\n");
        }
    }
}
