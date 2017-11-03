using System.Collections.Generic;

namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        private const int BoardSize = 64;

        public int? Id { get; set; }
        public Side TurnSide { get; }
        public IDictionary<string, BoardTile> Tiles { get; } = new Dictionary<string, BoardTile>(BoardSize);

        public Board()
        {
            // TODO: Fill dictionary
        }
    }
}
