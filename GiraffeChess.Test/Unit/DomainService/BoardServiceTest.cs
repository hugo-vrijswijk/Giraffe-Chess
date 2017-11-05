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
            var mockRepo = new MockBoardRepository();
            var sut = new GameService(mockRepo);

            var result = sut.NewGame().Id;
            var expected = 1;
            Assert.AreEqual(expected,result);
        }
    }
}