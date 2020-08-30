using CaseStudyMarsRover.Abstraction;
using MarsRover.Models;
using System;

namespace MarsRover.RoverCommands
{
    public class GeneratePlato : IRover
    {
        public void DoIt(string command, Rover rover)
        {
            rover.Plateau = new Plateau
            {
                XAxis = Convert.ToInt32(command.Split(' ')[0]),
                YAxis = Convert.ToInt32(command.Split(' ')[1])
            };
        }
    }
}