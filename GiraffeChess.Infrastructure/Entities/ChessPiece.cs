using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.ApplicationService.Entities
{
    public class ChessPiece
    {

        public ChessPiece(Entities.BoardTile tile, Piece pieceName, Side colour)
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
