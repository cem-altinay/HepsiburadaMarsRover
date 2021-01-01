using System;
using MarsRover.Application.Abstract;
using MarsRover.Application.Constants;
using MarsRover.Application.Model;

namespace MarsRover.Application.MoveCommand
{
  
    ///<summary>
    /// North rotate  move
    /// </summary>
    public class NorthCommand : IDirection
    {
        public Position Move(Position currentPosition, CommandType commandType)
        {
            switch (commandType)
            {
                case CommandType.R:
                    currentPosition.FaceDirectionType = DirectionType.E;
                    break;
                case CommandType.L:
                    currentPosition.FaceDirectionType = DirectionType.W;
                    break;
                case CommandType.M:
                    currentPosition.Y += 1;
                    break;
            }

            return currentPosition;
        }
    }
}
