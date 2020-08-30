using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.Movements
{
    public class SouthMove : IMove
    {
        public void Move(Position position) => position.Y--;
    }
}