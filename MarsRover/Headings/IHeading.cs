
namespace MarsRover
{
    public interface IHeading
    {
        public IHeading TurnRight();
        public IHeading TurnLeft();
        public Grid MoveForward(Grid grid);
        public Grid MoveBackward(Grid grid);
        public string GetHeading();
    }
}
