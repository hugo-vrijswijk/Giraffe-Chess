using System.Collections.Generic;

namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        private static readonly string[] Columns = { "A", "B", "C", "D", "E", "F", "G", "H" };
        private const int BoardSize = 8;

        public int? Id { get; set; }
        public Side TurnSide { get; set; }
        public IDictionary<string, BoardTile> Tiles { get; } = new Dictionary<string, BoardTile>(BoardSize * BoardSize);

        public Board()
        {
            for (var x = 1; x <= BoardSize; x++)
            {
                for (var y = 0; y < BoardSize; y++)
                {
                    var tileName = Columns[y] + x;
                    Tiles.Add(tileName, new BoardTile(tileName));
                }
            }
            // TODO: Fill board with pieces
        }

        public void SetTile(string position, ChessPiece piece)
        {
            var tile = Tiles[position];
            tile.Piece = piece;
            Tiles[position] = tile;
        }

        public override bool Equals(object obj)
        {
            return obj is Board board &&
                   EqualityComparer<int?>.Default.Equals(Id, board.Id) &&
                   TurnSide == board.TurnSide &&
                   EqualityComparer<IDictionary<string, BoardTile>>.Default.Equals(Tiles, board.Tiles);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)TurnSide;
                hashCode = (hashCode * 397) ^ (Tiles != null ? Tiles.GetHashCode() : 0);
                return hashCode;
            }
        }

    }
}
