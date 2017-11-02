using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService.Service;

namespace GiraffeChess.Test.Unit
{
    [TestClass]
    class BoardServiceTest
    {
        [TestMethod]
        public void NewGame_ShouldReturnNewBoardWithId1()
        {
            var sut = new GameService();
        }
    }
}