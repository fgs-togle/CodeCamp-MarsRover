
namespace MarsRover
{
    public class TurnLeftCommand : ICommand
    {
        private Rover _rover;

        public TurnLeftCommand(Rover rover) => _rover = rover;

        public void Execute() => _rover.TurnLeft();
    }
}
