
namespace MarsRover
{
    public class InvalidCommand :  ICommand
    {
        private Rover _rover;

        public InvalidCommand(Rover rover) => _rover = rover;

        public void Execute() => _rover.InvalidCommand();
    }
}
