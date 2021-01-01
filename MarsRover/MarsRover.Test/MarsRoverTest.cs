using System;
using MarsRover.Application.Model;
using Xunit;

namespace MarsRover.Test
{
    public class MarsRoverTest
    {
        private Rover _rover;

        [Fact]
        public void Test1()
        {
            var position = new Position(0, 0, 'N');
            _rover = new Rover(position);
            _rover.Move("MMM");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(0, result.X);
            Assert.Equal(3, result.Y);
            Assert.Equal(Application.Constants.DirectionType.N, result.FaceDirectionType);
        }

        [Fact]
        public void Test2()
        {
            var position = new Position(0, 2, 'E');
            _rover = new Rover(position);
            _rover.Move("MMLM");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(2, result.X);
            Assert.Equal(1, result.Y);
            Assert.Equal(Application.Constants.DirectionType.N, result.FaceDirectionType);
        }

        [Fact]
        public void Test3()
        {
            var position = new Position(0, 2, 'X');
            _rover = new Rover(position);
            _rover.Move("MMLM");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(2, result.X);
            Assert.Equal(1, result.Y);
            Assert.Equal(Application.Constants.DirectionType.N, result.FaceDirectionType);
        }


        [Fact]
        public void Test4()
        {
            var position = new Position(0, 1, 'S');
            _rover = new Rover(position);
            _rover.Move("MMLMT");
            var result = _rover.GetCurrentPosition();
            Assert.Equal(2, result.X);
            Assert.Equal(1, result.Y);
            Assert.Equal(Application.Constants.DirectionType.N, result.FaceDirectionType);
        }
    }
}
