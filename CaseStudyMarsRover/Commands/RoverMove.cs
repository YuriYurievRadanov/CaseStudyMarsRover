using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.RoverCommands
{
    public class RoverMove : IRoverExplore
    {
        public void DoIt(Rover rover)
        {
            rover.Move();
        }
    }
}