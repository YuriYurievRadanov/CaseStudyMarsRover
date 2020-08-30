using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.Movements
{
    public class WestMove : IMove
    {
        public void Move(Position position) => position.X--;
    }
}