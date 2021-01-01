using System;
using MarsRover.Application.Abstract;
using MarsRover.Application.Constants;
using MarsRover.Application.Model;

namespace MarsRover.Application.MoveCommand
{
    /// <summary>
    /// West rotate  move
    /// </summary>
    public class WestCommand : IDirection
    {
        public Position Move(Position currentPosition, CommandType commandType)
        {
            switch (commandType)
            {
                case CommandType.R:
                    currentPosition.FaceDirectionType = DirectionType.N;
                    break;
                case CommandType.L:
                    currentPosition.FaceDirectionType = DirectionType.S;
                    break;
                case CommandType.M:
                    currentPosition.X -= 1;
                    break;
            }

            return currentPosition;
        }
    }
}
