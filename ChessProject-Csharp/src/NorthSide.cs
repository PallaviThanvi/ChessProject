﻿using System.Collections.Generic;

namespace SolarWinds.MSP.Chess
{
    /// <summary>
    /// North side of the chess board
    /// </summary>
    public class NorthSide : Direction
    {
        /// <see cref="Direction.MoveForward(Position)"/>
        public override Position MoveForward(Position currentPosition) => new Position(currentPosition.XCoordinate, currentPosition.YCoordinate + 1);

        /// <see cref="Direction.MoveBackward(Position)"/>
        public override Position MoveBackward(Position currentPosition) => new Position(currentPosition.XCoordinate, currentPosition.YCoordinate - 1);

        /// <see cref="Direction.MoveLeft(Position)"/>
        public override Position MoveLeft(Position currentPosition) => new Position(currentPosition.XCoordinate - 1, currentPosition.YCoordinate);

        /// <see cref="Direction.MoveRight(Position)"/>
        public override Position MoveRight(Position currentPosition) => new Position(currentPosition.XCoordinate + 1, currentPosition.YCoordinate);

        /// <see cref="Direction.GetOppositeDirection()"/>
        public override Direction GetOppositeDirection() => new SouthSide();

        /// <see cref="Direction.GetInitialPositionsForPawn()"/>
        public override IEnumerable<Position> GetInitialPositionsForPawn() => new[] { new Position(0, 1), new Position(1, 1), new Position(2, 1), new Position(3, 1), new Position(4, 1), new Position(5, 1), new Position(6, 1), new Position(7, 1) };
    }
}