using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.Movements
{
    public class EastMove : IMove
    {
        public void Move(Position position) => position.X++;
    }
}