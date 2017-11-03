using System;
using System.Collections.Generic;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.ApplicationService.Mapper
{
    public class BoardMapper
    {
        public Board FromEntity(Entities.Board eBoard)
        {
            var board = new Board
            {
                Id = eBoard.Id,
                TurnSide = eBoard.Turn
            };
            foreach (var tile in eBoard.Tiles)
            {
                var position = tile.Position;
                var piece = tile.ChessPiece;
                var pieceToAdd = piece == null ? null : new ChessPiece(piece.PieceName, piece.Colour);
                board.SetTile(position, pieceToAdd); 
            }
            return board;
        }

        public Entities.Board ToEntity(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
