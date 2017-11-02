using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        private const int boardSize = 8;
        public Side TurnSide { get; set; }

        public BoardTile[,] Tiles { get; } = new BoardTile[boardSize, boardSize];

        public Board()
        {

        }
    }
}
