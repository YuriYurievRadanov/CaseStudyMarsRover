using CaseStudyMarsRover.Abstraction;
using MarsRover.RoverCommands;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarsRover.Common
{
    public static class Converter
    {
        private static readonly Dictionary<string, IRover> commandTypeDictionary = new Dictionary<string, IRover>
            {
                { @"^\d+ \d+$", new GeneratePlato() },
                { @"^\d+ \d+ [NSEW]$", new RoverLanding() },
                { @"^[LRM]+$", new RoverExplore() }
            };

        private static readonly Dictionary<string, IRoverExplore> exploreCommandTypeDictionary = new Dictionary<string, IRoverExplore>
            {
                { @"L", new RoverTurnLeft() },
                { @"R", new RoverTurnRight() },
                { @"M", new RoverMove() }
            };

        public static IRover ConvertToRoverCommand(string command)
        {
            var commandType = commandTypeDictionary.First(regexToCommandType => new Regex(regexToCommandType.Key).IsMatch(command));

            return commandType.Value;
        }

        public static IRoverExplore ConvertToRoverExploreCommand(string command)
        {
            var exploreCommandType = exploreCommandTypeDictionary.First(commandType => commandType.Key == command);

            return exploreCommandType.Value;
        }
    }
}