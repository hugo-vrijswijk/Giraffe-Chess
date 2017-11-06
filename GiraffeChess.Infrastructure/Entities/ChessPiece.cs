using GiraffeChess.Domain.Domain;

namespace GiraffeChess.Infrastructure.Entities
{
    public class ChessPiece
    {

        public ChessPiece(BoardTile tile, Piece pieceName, Side colour)
        {
            OnTile = tile ;
            PieceName = pieceName;
            Colour = colour;
        }

        public int? Id { get; set; }
        public BoardTile OnTile { get; set; }
        public Side Colour { get; set; }
        public Piece PieceName { get; set; }
    }
}
