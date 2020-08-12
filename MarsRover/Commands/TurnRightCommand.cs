
namespace MarsRover
{
    public class TurnRightCommand : ICommand
    {
        private Rover _rover;

        public TurnRightCommand(Rover rover) => _rover = rover;

        public void Execute() => _rover.TurnRight();
    }
}
