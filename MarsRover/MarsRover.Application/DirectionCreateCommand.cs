using System;
using MarsRover.Application.Abstract;
using MarsRover.Application.Constants;
using MarsRover.Application.MoveCommand;

namespace MarsRover.Application
{
    /// <summary>
   /// Creates a new move command according to the command type instance
    /// </summary>
    public class DirectionCreateCommand
    {
        public static IDirection GetDirectionCommand(DirectionType currentDirectionType)
        {
         
                return currentDirectionType switch
                {
                    DirectionType.E => new EastCommand(),
                    DirectionType.W => new WestCommand(),
                    DirectionType.S => new SouthCommand(),
                    DirectionType.N => new NorthCommand(),
                    _ => throw new NotImplementedException(),
                };
          
        }
    }
}
