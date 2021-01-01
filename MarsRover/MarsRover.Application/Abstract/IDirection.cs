using System;
using MarsRover.Application.Constants;
using MarsRover.Application.Model;

namespace MarsRover.Application.Abstract
{
    /// <summary>
    /// Guiding interface for routing
    /// </summary>
    public interface IDirection
    {
        Position Move(Position currentPosition, CommandType commandType);
    }
}
