using GiraffeChess.Domain.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GiraffeChess.Test.Unit.Domain
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void NewBoard_ShouldBeSize8By8()
        {
            var sut = new Board();
            
            Assert.AreEqual(64, sut.Tiles.Count);
        }

        [TestMethod]
        public void NewBoard_ShouldBeStartingSideWhite()
        {
            var sut = new Board();

            Assert.AreEqual(Side.White, sut.TurnSide);
        }

        [TestMethod]
        public void MovePiece_GivenNewBoard_ShouldMove()
        {
            var sut = new Board();
            var originalPiece = sut.Tiles["B1"].Piece;

            sut.Move("B1", "B3");

            Assert.IsNull(sut.Tiles["B1"].Piece);
            Assert.IsNotNull(sut.Tiles["B3"].Piece);           
            Assert.AreEqual(originalPiece, sut.Tiles["B3"].Piece);
        }
    }
}
