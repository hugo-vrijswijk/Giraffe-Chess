using GiraffeChess.DomainService.Service;
using GiraffeChess.Test.Unit.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiraffeChess.Test.Unit.DomainService
{
    [TestClass]
    public class BoardServiceTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void NewGame_ShouldReturnNewBoardWithId1()
        {

            var inMemoryDbRepo = new InMemoryDb(TestContext.TestName).BoardRepository;
            var sut = new BoardService(inMemoryDbRepo);

            var result = sut.NewGame().Id;

            const int expected = 1;
            Assert.AreEqual(expected, result);
        }
    }
}