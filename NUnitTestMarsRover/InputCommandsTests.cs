using System.Collections.Generic;
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
            var grid = new Grid(5, 5);
            var heading = new NorthHeading();
            var obstacle = new List<Obstacle>();
            var rover = new Rover(grid, heading, obstacle);
            rover.XCoordinate = 3;
            rover.YCoordinate = 3;
            var commandInput = new InputCommands(input);
            var commandFactory = commandInput.ReturnCommand();
            var command = commandFactory(rover);
            Assert.That(command.ToString(), Is.EqualTo(commandName));
        }
    }
}
