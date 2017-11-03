using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.Domain.Domain
{
    public class ChessPiece
    {
        public ChessPiece(Piece pieceName, Side colour)
        {
            PieceName = pieceName;
            Colour = colour;
        }

        public Side Colour { get; }
        public Piece PieceName { get; }

        public override bool Equals(object obj)
        {
            return obj is ChessPiece piece &&
                   Colour == piece.Colour &&
                   PieceName == piece.PieceName;
        }

        protected bool Equals(ChessPiece other)
        {
            return Colour == other.Colour && PieceName == other.PieceName;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Colour * 397) ^ (int) PieceName;
            }
        }
    }
}
