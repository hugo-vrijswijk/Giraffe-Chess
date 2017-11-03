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
    }
}
