using GiraffeChess.Domain.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.Fail("TODO");
        }
    }
}
