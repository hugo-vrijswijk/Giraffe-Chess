using System.Collections.Generic;
using System.Linq;
namespace GiraffeChess.Domain.Domain
{
    public class Board
    {
        private static readonly string[] Columns = { "A", "B", "C", "D", "E", "F", "G", "H" };
        private static readonly int[] AllowedRows = { 1, 2, 7,8 };
        private static readonly Piece[] ChessPreset = { Piece.Rook, Piece.Knight, Piece.Bishop, Piece.King, Piece.Queen, Piece.Bishop, Piece.Knight, Piece.Rook };
        private const int BoardSize = 8;
        public int? Id { get; set; }
        public Side TurnSide { get; set; }
        public IDictionary<string, BoardTile> Tiles { get; } = new Dictionary<string, BoardTile>(BoardSize * BoardSize);

        /// <summary>
        /// Create a domain board with all the chess pieces for the start.
        /// </summary>
        public Board()
        {
            InitializeBoard();
            SetupChessPieces();  
        }

        /// <summary>
        /// Set all the tiles to create a board.
        /// </summary>
        private void InitializeBoard()
        {
            for (var x = 1; x <= BoardSize; x++)
            {
                for (var y = 0; y < BoardSize; y++)
                {
                    var tileName = Columns[y] + x;
                    Tiles.Add(tileName, new BoardTile(tileName));
                }
            }
        }

        /// <summary>
        /// Setup the chess pieces at the board from a prefab for both sides.
        /// </summary>
        private void SetupChessPieces()
        {
            var columnsKeys = new List<string>(Tiles.Keys);
            var chessPieceIndex = 0;

            foreach (string key in columnsKeys)
            {
                var rowNumber = int.Parse(key.Substring(1));
                var allowedRow = AllowedRows.Contains(rowNumber);
                if (chessPieceIndex >= 8)
                {
                    chessPieceIndex = 0;
                }

                if (allowedRow)
                {
                    Side side = Side.White;
                    Piece chosenPiece = ChessPreset[chessPieceIndex];

                    if (rowNumber > 3)
                    {
                        side = Side.Black;
                    }
                    else if (rowNumber == 2 || rowNumber == 7)
                    {
                        chosenPiece = Piece.Pawn;
                    }

                    ChessPiece piece = new ChessPiece(chosenPiece, side);
                    Tiles[key].Piece = piece;
                    chessPieceIndex++;
                }

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

        public void Move(string from, string to)
        {
            var tileFrom = Tiles[from];
            SetTile(from, null);
            SetTile(to, tileFrom.Piece);
            
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
