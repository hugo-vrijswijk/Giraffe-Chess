using GiraffeChess.Domain.Domain;
using System.Collections.Generic;

namespace GiraffeChess.Infrastructure.Entities
{
    public class ChessPiece
    {

        public ChessPiece(Piece pieceName, Side colour)
        {
            PieceName = pieceName;
            Colour = colour;
        }

        public int? Id { get; set; }
        public BoardTile OnTile { get; set; }
        public Side Colour { get; set; }
        public Piece PieceName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ChessPiece piece &&
                   EqualityComparer<int?>.Default.Equals(Id, piece.Id) &&
                   EqualityComparer<BoardTile>.Default.Equals(OnTile, piece.OnTile) &&
                   Colour == piece.Colour &&
                   PieceName == piece.PieceName;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (OnTile != null ? OnTile.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Colour;
                hashCode = (hashCode * 397) ^ (int) PieceName;
                return hashCode;
            }
        }
    }
}
