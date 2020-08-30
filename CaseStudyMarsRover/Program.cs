using MarsRover.Common;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseStudyMarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder commands = new StringBuilder();
            commands.AppendLine("5 5");
            commands.AppendLine("1 2 N");
            commands.AppendLine("LMLMLMLMM");
            commands.AppendLine("3 3 E");
            commands.Append("MMRMMRMRRM");

            List<string> listofCommands = commands.ToString().Split(Environment.NewLine).ToList();

            var commandList = listofCommands.Select(x => (
                Command: Converter.ConvertToRoverCommand(x),
                CommandParameter: x
            )).ToList();

            var rover = new Rover();

            for (int i = 0; i < commandList.Count; i++)
            {
                (Abstraction.IRover Command, string CommandParameter) = commandList[i];
                Command.DoIt(CommandParameter, rover);
            }

            Console.ReadLine();
        }
    }
}