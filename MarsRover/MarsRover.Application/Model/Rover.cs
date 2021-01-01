using System;
using System.Linq;
using MarsRover.Application.Constants;

namespace MarsRover.Application.Model
{
    /// <summary>
    /// Rover
    /// </summary>
    public class Rover
    {
        private Position _position;
        public Rover(Position position)
        {
            _position = position;
        }

        /// <summary>
        /// Rover move command
        /// </summary>
        /// <param name="input"></param>
        public void Move(string input) => input.ToList().ForEach(moveChar =>
        {
            if (Enum.TryParse(moveChar.ToString(), out CommandType commandType))
                _position = DirectionCreateCommand.GetDirectionCommand(_position.FaceDirectionType).Move(_position, commandType);
            else
                throw new Exception(Messages.IncorrectCommandType);
          
        });

        public Position GetCurrentPosition() => _position;
    }
}
