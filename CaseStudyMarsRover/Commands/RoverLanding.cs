using CaseStudyMarsRover.Abstraction;
using MarsRover.Enums;
using MarsRover.Models;
using System;

namespace MarsRover.RoverCommands
{
    public class RoverLanding : IRover
    {
        public void DoIt(string command, Rover rover)
        {
            rover.Land(Convert.ToInt32(command.Split(' ')[0]),
                        Convert.ToInt32(command.Split(' ')[1]),
                        (Orientation)Enum.Parse(typeof(Orientation), command.Split(' ')[2].ToString()));
        }
    }
}