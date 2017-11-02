using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        private const int boardSize = 8;

        public int? Id { get; set; }
        public Side TurnSide { get; }
        public IDictionary<string, BoardTile> Tiles { get; } = new Dictionary<string, BoardTile>(64);

        public Board()
        {
            // TODO: Fill dictionary
        }
    }
}
