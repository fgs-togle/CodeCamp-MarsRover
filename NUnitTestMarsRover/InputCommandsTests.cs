using NUnit.Framework;
using MarsRover;

namespace NUnitTestMarsRover
{
    public class InputCommandsTests
    {
        [Test]
        [TestCase("f", "F")]
        [TestCase("b", "B")]
        [TestCase("l", "L")]
        [TestCase("r", "R")]
        [TestCase("g", "G")]

        public void InputCommands_GivenACommandLetter_ReturnCommandInUpperCase(string input, string expectedOutput)
        {
            var letter = new InputCommands(input);
            Assert.That(letter.InputCommand(), Is.EqualTo(expectedOutput));
        }


        [Test]
        [TestCase("f", "MarsRover.MoveForwardCommand")]
        [TestCase("b", "MarsRover.MoveBackwardCommand")]
        [TestCase("l", "MarsRover.TurnLeftCommand")]
        [TestCase("r", "MarsRover.TurnRightCommand")]
        [TestCase("g", "MarsRover.InvalidCommand")]
        public void ValidateAndReturnCommand_GivenACommandLetter_ReturnTheProperCommandName(string input, string commandName)
        {
            var grid = new Grid(3, 3, 5, 5);
            var heading = new NorthHeading();
            var rover = new Rover(grid, heading);
            var commandInput = new InputCommands(input);
            var commandFactory = commandInput.ValidateAndReturnCommand();
            var command = commandFactory(rover);
            Assert.That(command.ToString(), Is.EqualTo(commandName));
        }
    }
}
