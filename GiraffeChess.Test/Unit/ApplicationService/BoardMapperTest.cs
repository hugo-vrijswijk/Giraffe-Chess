using System.Collections.Generic;
using System.Linq;
using GiraffeChess.Domain.Domain;
using GiraffeChess.Infrastructure.Mapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities = GiraffeChess.Infrastructure.Entities;

namespace GiraffeChess.Test.Unit.ApplicationService
{
    [TestClass]
    public class BoardMapperTest
    {
        [TestMethod]
        public void FromEntity_ShouldHaveAllProperties()
        {
            var sut = new BoardMapper(new BoardTileMapper(new ChessPieceMapper()));
            var board = new Entities.Board() { Turn = Side.Black, Id = 1, Tiles = new List<Entities.BoardTile>(64) };
            board.Tiles.Add(new Entities.BoardTile()
            {
                Id = 3,
                Position = "A1",
                ChessPiece = new Entities.ChessPiece(Piece.Rook, Side.White)
            });

            var result = sut.FromEntity(board);

            var expected = new Board { TurnSide = Side.Black, Id = 1 };
            expected.SetTile("A1", new ChessPiece(Piece.Rook, Side.White));
            Assert.AreEqual(result.Id, expected.Id);
            Assert.AreEqual(result.TurnSide, expected.TurnSide);
            foreach (var tilePair in result.Tiles)
            {
                Assert.AreEqual(tilePair.Value, expected.Tiles[tilePair.Key]);
            }
        }

        [TestMethod]
        public void ToEntity_ShouldHaveAllProperties()
        {
            var sut = new BoardMapper(new BoardTileMapper(new ChessPieceMapper()));
            var board = new Board()
            {
                Id = 2,
                TurnSide = Side.Black
            };
            board.SetTile("C1", new ChessPiece(Piece.Bishop, Side.Black));

            var actual = sut.ToEntity(board);

            Assert.AreEqual(2, actual.Id);
            Assert.AreEqual(Side.Black, actual.Turn);
            var actualPiece = actual.Tiles.First(tile => tile.Position.Equals("C1")).ChessPiece;
            var expectedPiece = new Entities.ChessPiece(Piece.Bishop, Side.Black) { OnTile = actualPiece.OnTile };
            Assert.AreEqual(expectedPiece, actualPiece);
        }
    }
}
