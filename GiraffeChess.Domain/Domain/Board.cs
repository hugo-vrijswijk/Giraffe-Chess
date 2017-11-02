using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        public Side TurnSide { get; set; }

        public BoardTile[,] Tiles { get; } = new BoardTile[8, 8];
        public Board()
        {

        }
    }
}
