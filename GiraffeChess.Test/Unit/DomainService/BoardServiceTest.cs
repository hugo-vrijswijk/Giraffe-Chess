using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService.Service;
using GiraffeChess.Test.Unit.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiraffeChess.Test.Unit.DomainService
{
    [TestClass]
    public class BoardServiceTest
    {
        [TestMethod]
        public void NewGame_ShouldReturnNewBoardWithId1()
        {
            var sut = new GameService(new MockBoardRepository());

            var actual = sut.NewGame();

            var expected = new Board { Id = 1 };
            Assert.AreEqual(expected, actual);
        }
    }
}