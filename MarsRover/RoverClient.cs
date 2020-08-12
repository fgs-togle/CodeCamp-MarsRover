using System;

namespace MarsRover
{
    public class RoverClient
    {
        private Grid _grid;
        private IHeading _heading;
        private Rover _rover;

        public RoverClient()
        {
            _grid = new Grid(3, 3, 5, 5);
            _heading = new NorthHeading();
            _rover = new Rover(_grid, _heading);
        }

        
        public void RoverInstructions()
        {
            var commands = string.Empty;
            DisplayInstructions();
            
            while(!commands.Equals("X"))
            {
                Console.WriteLine($"Your current position on the surface grid is {_rover.XCoordinate()}, {_rover.YCoodinate()} and the Rover is facing {_rover.Direction()}.\n");
                Console.WriteLine("Please enter your rover commands: ");
                commands = Console.ReadLine().ToUpper().Replace(" ", "");
                _rover = _rover.ExecuteCommands(commands);
            }
        }

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
