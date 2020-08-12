using System.Collections.Generic;

namespace MarsRover
{
    public class Rover
    {
        private Grid _grid;
        private IHeading _heading;

        public Rover(Grid grid, IHeading heading)
        {
            _grid = grid.GridEntryAndSizeValidation(grid);
            _heading = heading;
        }

        public void TurnLeft() => _heading = _heading.TurnLeft();

        public void TurnRight() => _heading = _heading.TurnRight();

        public void MoveForward() => _grid = _heading.MoveForward(_grid);

        public void MoveBackward() => _grid = _heading.MoveBackward(_grid);

        public void InvalidCommand() { }

        public string Direction() => _heading.GetHeading();

        public int XCoordinate() => _grid.XCoordinate();

        public int YCoodinate() => _grid.YCoordinate();

        public int GridHeight() => _grid.GridHeight();

        public int GridWidth() => _grid.GridWidth();

        public Rover ExecuteCommands(string commands)
        {
            foreach (var letter in commands)
            {
                var commandInput = new InputCommands(letter.ToString());
                var commandFactory = commandInput.ValidateAndReturnCommand();
                var command = commandFactory(this);
                var previousLocation = _grid;
                command.Execute();
            }
            return this;
        }
    }
}
