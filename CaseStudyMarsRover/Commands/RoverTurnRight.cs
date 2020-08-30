using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.RoverCommands
{
    public class RoverTurnRight : IRoverExplore
    {
        public void DoIt(Rover rover)
        {
            rover.TurnRight();
        }
    }
}