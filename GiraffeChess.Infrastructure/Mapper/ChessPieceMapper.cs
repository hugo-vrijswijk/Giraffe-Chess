using GiraffeChess.Domain.Domain;
using Entities = GiraffeChess.Infrastructure.Entities;

namespace GiraffeChess.Infrastructure.Mapper
{
    public class ChessPieceMapper
    {
        public ChessPiece FromEntity(Entities.ChessPiece entityChessPiece)
        {
            return new ChessPiece(entityChessPiece.PieceName, entityChessPiece.Colour);
        }

        public Entities.ChessPiece ToEntity(ChessPiece entityPiece, Entities.BoardTile onTile)
        {
            return new Entities.ChessPiece(entityPiece.PieceName, entityPiece.Colour)
            {
                OnTile = onTile
            };
        }
    }
}
