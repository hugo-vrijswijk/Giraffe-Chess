using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService.Service;
using GiraffeChess.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GiraffeChess.Test.Unit.WebAPI
{
    [TestClass]
    public class BoardControllerTest
    {
        private BoardController sut;
        private Mock<IGameService> gameServiceMock;

        [TestInitialize]
        public void Init()
        {
            gameServiceMock = new Mock<IGameService>();
            sut = new BoardController(gameServiceMock.Object);

            gameServiceMock
                .Setup(gameService => gameService.NewGame())
                .Returns(new Board() { Id = 1 });
        }

        [TestMethod]
        public void Get_GivenNoBoardId_ShouldCallNewGame()
        {
            var result = sut.Get();

            gameServiceMock.Verify(gameService => gameService.NewGame());
        }

        [TestMethod]
        public void Get_GivenNoBoardId_ShouldReturnCreatedResponseWithLocation()
        {
            var result = sut.Get();
            
            var expectedBoard = new Board() { Id = 1 };
            Assert.IsInstanceOfType(result, typeof(CreatedResult));
            Assert.AreEqual("board/1", ((CreatedResult)result).Location);
            Assert.AreEqual(expectedBoard, ((CreatedResult)result).Value);
        }

    }
}
