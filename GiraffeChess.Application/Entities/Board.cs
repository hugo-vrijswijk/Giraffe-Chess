using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.ApplicationService.Entities
{
    public class Board
    {
        public int? Id { get; set; }
        public Side Turn { get; set; }
        public List<BoardTile> Tiles { get; set; }

        public Board()
        {
            Tiles = new List<BoardTile>();
        }

        internal void SetTile(string position, Entities.ChessPiece pieceToAdd)
        {
            BoardTile tile = new BoardTile
            {
                ChessPiece = pieceToAdd,
                Position = position
            };
            Tiles.Add(tile);
        }
    }
}
