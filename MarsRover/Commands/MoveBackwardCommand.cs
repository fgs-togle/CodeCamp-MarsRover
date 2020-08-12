
namespace MarsRover
{
    public class MoveBackwardCommand : ICommand
    {
        private Rover _rover;

        public MoveBackwardCommand(Rover rover) => _rover = rover;

        public void Execute() => _rover.MoveBackward();
    }
}
