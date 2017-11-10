using System.Collections.Generic;
using GiraffeChess.Domain.Domain;

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

        public void SetTile(string position, ChessPiece pieceToAdd)
        {
            var tile = new BoardTile
            {
                ChessPiece = pieceToAdd,
                Position = position
            };
            Tiles.Add(tile);
        }
    }
}
