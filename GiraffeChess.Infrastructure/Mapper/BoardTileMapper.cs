using System;
using System.Collections.Generic;
using System.Linq;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.Infrastructure.Mapper
{
    public class BoardTileMapper
    {
        private ChessPieceMapper ChessPieceMapper { get; }

        public BoardTileMapper(ChessPieceMapper chessPieceMapper)
        {
            ChessPieceMapper = chessPieceMapper;
        }

        public List<Entities.BoardTile> ToEntityAll(IDictionary<string, BoardTile> boardTiles)
        {
            return boardTiles
                .Select(boardTilePair =>
                    ToEntity(boardTilePair.Value))
                .ToList();
        }

        public Entities.BoardTile ToEntity(BoardTile tile)
        {
            var entityTile = new Entities.BoardTile
            {
                Position = tile.Position,

            };
            if (tile.Piece != null)
            {
                entityTile.ChessPiece = ChessPieceMapper.ToEntity(tile.Piece, entityTile);
            }
            return entityTile;
        }

        public BoardTile FromEntity(Entities.BoardTile tile)
        {
            var domainTile = new BoardTile(tile.Position);
            if (tile.ChessPiece != null)
            {
                domainTile.Piece = ChessPieceMapper.FromEntity(tile.ChessPiece);
            }
            return domainTile;
        }
    }
}
