using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;

namespace MarsRover.RoverCommands
{
    public class RoverTurnLeft : IRoverExplore
    {
        public void DoIt(Rover rover)
        {
            rover.TurnLeft();
        }
    }
}