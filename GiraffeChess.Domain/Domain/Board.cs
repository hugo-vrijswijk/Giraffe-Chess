using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        private const int boardSize = 8;
        public Side TurnSide { get; set; }

        public IDictionary<string, BoardTile> Tiles { get; } = new Dictionary<string, BoardTile>(64);

        public Board()
        {

        }
    }
}
