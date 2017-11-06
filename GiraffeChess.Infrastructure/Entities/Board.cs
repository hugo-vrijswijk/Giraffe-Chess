using System.Collections.Generic;
using GiraffeChess.Domain.Domain;
using BoardTile = GiraffeChess.Infrastructure.Entities.BoardTile;

namespace GiraffeChess.Infrastructure.Entities
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

        internal void SetTile(string position, ChessPiece pieceToAdd)
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
