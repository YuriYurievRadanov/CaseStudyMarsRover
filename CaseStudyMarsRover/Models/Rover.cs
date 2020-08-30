using CaseStudyMarsRover.Abstraction;
using MarsRover.Common;
using MarsRover.Enums;
using MarsRover.Movements;

namespace MarsRover.Models
{
    public class Rover
    {
        public Position CurrentPosition { get; set; }
        public Plateau Plateau { get; set; }
        public Orientation CurrentOrientation { get; set; }
        public bool IsInBoundaries(Position currentPosition)
        {
            return currentPosition.X >= 0 && currentPosition.Y >= 0 && currentPosition.X <= Plateau.XAxis && currentPosition.Y <= Plateau.YAxis;
        }

        public Position Position => CurrentPosition;

        public IMove DirectionOfMovement;
        public void Move()
        {
            DirectionOfMovement.Move(this.CurrentPosition);

            if (IsInBoundaries(this.CurrentPosition) == false)
                throw new FailedException("Mission failed !");
        }

        public void Land(int x, int y, Orientation orientation)
        {
            this.CurrentPosition = new Position() { X = x, Y = y };
            this.CurrentOrientation = orientation;

            UpdateMovementforOrientation();
        }

        public void TurnLeft()
        {
            CurrentOrientation = CurrentOrientation.Previous();

            UpdateMovementforOrientation();
        }

        public void TurnRight()
        {
            CurrentOrientation = CurrentOrientation.Next();

            UpdateMovementforOrientation();
        }

        public void UpdateMovementforOrientation()
        {
            if (CurrentOrientation == Orientation.N)
            {
                DirectionOfMovement = new NorthMove();
            }

            if (CurrentOrientation == Orientation.W)
            {
                DirectionOfMovement = new WestMove();
            }

            if (CurrentOrientation == Orientation.E)
            {
                DirectionOfMovement = new EastMove();
            }

            if (CurrentOrientation == Orientation.S)
            {
                DirectionOfMovement = new SouthMove();
            }
        }
    }
}