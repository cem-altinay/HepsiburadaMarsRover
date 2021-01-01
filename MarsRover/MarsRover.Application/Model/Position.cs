using System;
using MarsRover.Application.Constants;

namespace MarsRover.Application.Model
{
    /// <summary>
    /// Position
    /// </summary>
    public class Position
    {
        public int X{ get; set; }
        public int Y { get; set; }

        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public DirectionType FaceDirectionType { get; set; }

        public Position(int x, int y , char direction,int maxX=5,int maxY=5)
        {
            X = x;
            Y = y;
            MaxX = maxX;
            MaxY = maxY;
            SetFaceDirectionType(direction);
            if (!IsSetPositions())
                throw new Exception(Messages.PositionEntryOutsideField);
        }

        private bool IsSetPositions()
        {
            return (X >= 0) && (X < MaxX) && (Y >= 0) && (Y < MaxY);
        }

        private void SetFaceDirectionType(char direction)
        {
            if (Enum.TryParse(direction.ToString(), out DirectionType directionType))
                FaceDirectionType = directionType;
            else
                throw new Exception(Messages.IncorrectDirectionType);

        }
    }
}
