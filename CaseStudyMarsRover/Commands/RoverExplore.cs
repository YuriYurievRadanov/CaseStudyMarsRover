using CaseStudyMarsRover.Abstraction;
using MarsRover.Common;
using MarsRover.Models;
using System;
using System.Linq;

namespace MarsRover.RoverCommands
{
    public class RoverExplore : IRover
    {
        void IRover.DoIt(string command, Rover rover)
        {
            var exploreCommands = GetCommand(command).Select(x => Converter.ConvertToRoverExploreCommand(x.ToString())).ToList();

            foreach (var ec in from exploreCommand in exploreCommands
                              let c = exploreCommand
                              select c)
            {
                ec.DoIt(rover);
            }

            Console.WriteLine($"{rover.CurrentPosition.X} {rover.CurrentPosition.Y} {rover.CurrentOrientation}");

            static string GetCommand(string command)
            {
                return command;
            }
        }
    }
}