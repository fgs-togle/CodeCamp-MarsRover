using System;

namespace MarsRover
{
    public class RoverClient
    {
        public void RoverInstructions()
        {
            DisplayInstructions();
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
