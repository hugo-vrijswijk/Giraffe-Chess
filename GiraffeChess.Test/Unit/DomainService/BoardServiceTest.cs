using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService.Service;
using GiraffeChess.Domain.Domain;
using GiraffeChess.Test.Unit.Mock;

namespace GiraffeChess.Test.Unit
{
    [TestClass]
    class BoardServiceTest
    {
        [TestMethod]
        public void NewGame_ShouldReturnNewBoardWithId1()
        {
            var sut = new GameService(new MockBoardRepository());

            var actual = sut.NewGame();

            var expected = new Board { Id = 1 };
            AreEqual(expected, actual);
        }
    }
}