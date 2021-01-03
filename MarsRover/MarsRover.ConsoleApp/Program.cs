using System;
using System.Linq;
using MarsRover.Application.Constants;
using MarsRover.Application.Model;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        STARTPOINT:
            Console.BackgroundColor = ConsoleColor.Black;
            try
            {
            
                Console.WriteLine("Gezegen X ve Y boyutlarını giriniz örn (55)");
                var gridAreaCommand = Console.ReadLine();
                Console.WriteLine("Rover aracın konumunu giriniz. örn (12N)");
                var roverPositionCommand = Console.ReadLine();
                Console.WriteLine("Rover aracına komut giriniz. örn (LMLMLMLMM)");
                var roverMoveCommand = Console.ReadLine();
          
                var gridArea = RoverInputHelper.ValidateGridAreaCommand(gridAreaCommand);
                var roverPosition = RoverInputHelper.ValidateRoverPositionCommand(roverPositionCommand);
                var position = new Position(x: roverPosition.x, y: roverPosition.y, direction: roverPosition.command, gridArea.maxX, gridArea.maxY);
                Rover rover1 = new(position);
                rover1.Move(roverMoveCommand);
                var result1 = rover1.GetCurrentPosition();
                Console.WriteLine(result1.ToString());
                goto STARTPOINT;
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                goto STARTPOINT;
            }

        }
    }

    public class RoverInputHelper
    {
        public static (int maxX, int maxY) ValidateGridAreaCommand(string command)
        {
            if (command.Length != 2)
                throw new Exception("The command entered must be 2 characters.");

            var commandArry = command.ToCharArray();

            (int x, int y) gridArea=(5,5);

            for (int i = 0; i < commandArry.Length; i++)
            {
                if (!int.TryParse(commandArry[i].ToString(), out int value))
                {
                    throw new Exception("The command entered must be number");
                } 
                else
                {
                    switch (i)
                    {
                        case 0:
                            gridArea.x = value;
                            break;
                        default:
                            gridArea.y = value;
                            break;
                    }
                }
            }

            return gridArea;
        }

        public static (int x, int y , char command) ValidateRoverPositionCommand(string command)
        {
            if (command.Length != 3)
                throw new Exception("The command entered must be 3 characters.");

            var commandArry = command.ToCharArray();

            (int x, int y, char command) roverPositionCommand = (0, 0, (char)DirectionType.N);

            for (int i = 0; i < commandArry.Length; i++)
            {
                if(i==0 || i == 1)
                {
                    if (!int.TryParse(commandArry[i].ToString(), out int value))
                    {
                        throw new Exception("The command entered must be number");
                    }
                    else
                    {
                        switch (i)
                        {
                            case 0:
                                roverPositionCommand.x = value;
                                break;
                            default:
                                roverPositionCommand.y = value;
                                break;
                        }
                    }
                }
                else
                {
                    var directionList = Enum.GetValues(typeof(DirectionType)).Cast<DirectionType>().Select(s => (char)s).ToList();

                    var directionControl = directionList.Any(a => a == commandArry[i]);
                    if(directionControl)
                     roverPositionCommand.command = commandArry[i];
                    else
                        throw new Exception($"Value entered must be one of '{string.Join(",",directionList)}'");
                }
            }

            return roverPositionCommand;
        }
    }
}
