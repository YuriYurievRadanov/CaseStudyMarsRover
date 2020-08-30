using MarsRover.Models;

namespace CaseStudyMarsRover.Abstraction
{
    public interface IRover
    {
        void DoIt(string command, Rover rover);
    }
}
