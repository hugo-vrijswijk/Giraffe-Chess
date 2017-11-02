using GiraffeChess.Domain.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace GiraffeChess.Test
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void NewBoard_ShouldBeSize8By8()
        {
            var sut = new Board();
            
            AreEqual(64, sut.Tiles.Count);
        }

        [TestMethod]
        public void NewBoard_ShouldBeFilledOnBothSides()
        {
            var sut = new Board();

            Fail("TODO");
        }

        [TestMethod]
        public void MovePiece_GivenNewBoard_ShouldMove()
        {
            Fail("TODO");
        }
    }
}
