using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.Domain.Domain
{
    public class BoardTile
    {
        public string Position { get; }
        public ChessPiece Piece { get; set; }
        public BoardTile(string position)
        {
            Position = position;
        }

        public override bool Equals(object obj)
        {
            return obj is BoardTile tile &&
                   Position == tile.Position &&
                   EqualityComparer<ChessPiece>.Default.Equals(Piece, tile.Piece);
        }

        protected bool Equals(BoardTile other)
        {
            return string.Equals(Position, other.Position) && Equals(Piece, other.Piece);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Position != null ? Position.GetHashCode() : 0) * 397) ^ (Piece != null ? Piece.GetHashCode() : 0);
            }
        }
    }
}
