
namespace MarsRover
{
    public interface IHeading
    {
        public IHeading TurnRight();
        public IHeading TurnLeft();
        public void MoveForward(Rover rover, Grid grid);
        public void MoveBackward(Rover rover, Grid grid);
        public string GetHeading();
    }
}
