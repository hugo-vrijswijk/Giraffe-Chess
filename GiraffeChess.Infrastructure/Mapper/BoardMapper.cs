using System.Collections.Generic;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.Infrastructure.Mapper
{
    public class BoardMapper
    {
        private BoardTileMapper BoardTileMapper { get; }

        public BoardMapper(BoardTileMapper boardTileMapper)
        {
            BoardTileMapper = boardTileMapper;
        }
        public Board FromEntity(Entities.Board eBoard)
        {
            var board = new Board
            {
                Id = eBoard.Id,
                TurnSide = eBoard.Turn,
            };
            foreach (var tile in eBoard.Tiles)
            {
                var boardTile = BoardTileMapper.FromEntity(tile);
                board.Tiles[tile.Position] = boardTile;
            }
            return board;
        }

        public Entities.Board ToEntity(Board board)
        {
            var entity = new Entities.Board
            {
                Id = board.Id,
                Turn = board.TurnSide,
                Tiles = BoardTileMapper.ToEntityAll(board.Tiles)
            };
            //foreach (var tile in board.Tiles)
            //{
            //    var position = tile.Value.Position;
            //    var piece = tile.Value.Piece;
            //    Entities.BoardTile boardTile = new Entities.BoardTile
            //    {
            //        Position = position,
                    
            //    };

            //    var pieceToAdd = piece == null ? null : new Entities.ChessPiece(piece.PieceName, piece.Colour);
            //    entity.SetTile(position, pieceToAdd);
            //}
            return entity;

        }

    }
}

