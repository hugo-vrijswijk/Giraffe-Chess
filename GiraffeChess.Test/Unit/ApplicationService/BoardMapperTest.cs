using System.Collections.Generic;
using System.Linq;
using GiraffeChess.ApplicationService.Mapper;
using GiraffeChess.Domain.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Board = GiraffeChess.Domain.Domain.Board;
using Entity = GiraffeChess.ApplicationService.Entities;

namespace GiraffeChess.Test.Unit.ApplicationService
{
    [TestClass]
    public class BoardMapperTest
    {
        [TestMethod]
        public void FromEntity_ShouldHaveAllProperties()
        {
            var sut = new BoardMapper();

            var board = new Entity.Board() {Turn = Side.Black, Id = 1, Tiles = new List<Entity.BoardTile>(64)};
            var result = sut.FromEntity(board);

            var expected = new Board() { TurnSide = Side.Black, Id = 1};
            Assert.AreEqual(result.Id, expected.Id);
            Assert.AreEqual(result.TurnSide, expected.TurnSide);

            foreach (var tilePair in result.Tiles)
            {
                Assert.AreEqual(tilePair.Value, expected.Tiles[tilePair.Key]);
            }
        }
    }
}
