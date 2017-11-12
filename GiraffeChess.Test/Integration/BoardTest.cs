using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService.Command;
using GiraffeChess.DomainService.Service;
using GiraffeChess.Infrastructure.Mapper;
using GiraffeChess.Infrastructure.Repository;
using GiraffeChess.Test.Unit.Mock;
using GiraffeChess.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiraffeChess.Test.Integration
{
    [TestClass]
    [TestCategory("Integration")]
    public class BoardTest
    {
        private BoardController controller;
        private InMemoryDb inMemoryDb;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Init()
        {
            inMemoryDb = new InMemoryDb(TestContext.TestName);

            var repo = inMemoryDb.BoardRepository;
            var service = new BoardService(repo);
            controller = new BoardController(service);
        }

        [TestMethod]
        public void NewGame_ShouldProvideNewBoard()
        {
            var result = controller.NewGame();

            Assert.IsInstanceOfType(result, typeof(CreatedResult));
            var createdResult = (CreatedResult) result;
            Assert.AreEqual("board/2", createdResult.Location);
            var expectedBoard = new Board() {Id = 2};
            Assert.AreEqual(expectedBoard, createdResult.Value);
        }

        [TestMethod]
        public void Move_GivenABoard_ShouldMovePieceAndReturnBoard()
        {
            var board = (Board) ((CreatedResult) controller.NewGame()).Value;

            var result = controller.Move(new MoveCommand(board.Id.Value, "A2", "A3"));

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var boardReturned = (Board) ((OkObjectResult) result).Value;
            Assert.IsNull(boardReturned.Tiles["A2"].Piece);
            var actualPiece = boardReturned.Tiles["A3"].Piece;
            Assert.IsNotNull(actualPiece);
            Assert.AreEqual(Piece.Pawn, actualPiece.PieceName);
        }
    }
}
