using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;
using GiraffeChess.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GiraffeChess.Test.Features.Implementations
{
    [Binding]
    public class ChessGameStartsTest
    {
        private IActionResult _controllerResult;
        [Given(@"A new board is created")]
        public void GivenANewBoardIsCreated()
        {
            var controller = (BoardController)ScenarioContext.Current["BoardController"];
            _controllerResult = controller.NewGame();
        }

        [When(@"The chessboard is loaded with chesspieces")]
        public void WhenTheChessboardIsLoadedWithChesspieces()
        {
            
        }

        [Then(@"The side white should be chosen")]
        public void ThenTheSideWhiteShouldBeChosen()
        {
            var board = ((CreatedResult) _controllerResult).Value as Board;

            Assert.IsNotNull(board);
            Assert.AreEqual(Side.White, board.TurnSide);
        }
    }
}
