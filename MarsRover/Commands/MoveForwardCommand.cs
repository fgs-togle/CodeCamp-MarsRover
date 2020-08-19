﻿
namespace MarsRover
{
    public class MoveForwardCommand : ICommand
    {
        private Rover _rover;

        public MoveForwardCommand(Rover rover) => _rover = rover;

        public void Execute() => _rover.MoveForward();
    }
}
