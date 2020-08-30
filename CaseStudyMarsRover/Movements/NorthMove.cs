using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.Movements
{
    public class NorthMove : IMove
    {
        public void Move(Position position) => position.Y++;
    }
}