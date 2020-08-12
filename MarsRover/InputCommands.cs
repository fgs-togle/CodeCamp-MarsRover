using System;

namespace MarsRover
{
    public class InputCommands
    {
        private string[] _commands = { "L", "R", "F", "B" };
        private string _input;

        public InputCommands(string input) => _input = input.ToUpper();

        public Func<Rover, ICommand> ValidateAndReturnCommand()
        {
            if (ValidCommandLetter(_input))
            {
                switch (_input)
                {
                    case ("L"):
                        return Rover => new TurnLeftCommand(Rover);
                    case ("R"):
                        return Rover => new TurnRightCommand(Rover);
                    case ("F"):
                        return Rover => new MoveForwardCommand(Rover);
                    case ("B"):
                        return Rover => new MoveBackwardCommand(Rover);
                }
            }

            return Rover => new InvalidCommand(Rover);

        }

        private bool ValidCommandLetter(string input) => Array.Exists(_commands, commandLetter => commandLetter == input);

        public string InputCommand() => _input;

    }
}