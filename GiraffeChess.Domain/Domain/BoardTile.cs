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
    }
}
