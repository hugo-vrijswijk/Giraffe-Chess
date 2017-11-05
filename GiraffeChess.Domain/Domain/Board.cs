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

        /// <summary>
        /// Create a domain board with all the chess pieces for the start.
        /// </summary>
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
            var keys = new List<string>(Tiles.Keys);
            foreach (string key in keys)
            {
                //TODO Fill board with the right pieces for now fill with all the pieces.
                Tiles[key].Piece = new ChessPiece(Piece.Bishop, Side.Black);
            }
            
        }
        /// <summary>
        /// Set the tile(s) on the right position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="piece"></param>
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
