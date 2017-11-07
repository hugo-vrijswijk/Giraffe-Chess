using GiraffeChess.Domain.Domain;

namespace GiraffeChess.Infrastructure.Mapper
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
            Entities.Board entity = new Entities.Board
            {
                Id = board.Id,
                Turn = board.TurnSide,
                
            };
            foreach (var tile in board.Tiles)
            {
                var position = tile.Value.Position;
                var piece = tile.Value.Piece;
                Entities.BoardTile boardTile = new Entities.BoardTile
                {
                    Position = position,
                    
                };

                var pieceToAdd = piece == null ? null : new Entities.ChessPiece(piece.PieceName, piece.Colour);
                entity.SetTile(position, pieceToAdd);
            }
            return entity;

        }

    }
}

