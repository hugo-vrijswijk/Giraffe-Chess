using System;
using System.Linq;
using GiraffeChess.Domain.Domain;
using GiraffeChess.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GiraffeChess.Test.Features.Implementations
{
    [Binding]
    public class SetChessPiecesTest
    {
        private Board _board;
       

        [Given(@"The new board is created")]
        public void GivenTheNewBoardIsCreated()
        {
            var controller = (BoardController)ScenarioContext.Current["BoardController"];
            _board = (Board) ((CreatedResult) controller.NewGame()).Value;
        }
        
        [Then(@"On each place a piece with the right colour should be set")]
        public void ThenOnEachPlaceAPieceWithTheRightColourShouldBeSet(Table table)
        {
            var expectedPieces = table.Rows;
            Assert.AreEqual(32, expectedPieces.Count);
            Assert.AreEqual(32, _board.Tiles.Count(tile => tile.Value.Piece != null));
            foreach (var expectedPiece in expectedPieces)
            {
                var expectedOnTile = expectedPiece["Place"];
                Enum.TryParse(expectedPiece["Piece"], out Piece expectedPieceEnum);
                Enum.TryParse(expectedPiece["Colour"], out Side expectedSideEnum);
                var expectedChessPiece = new ChessPiece(expectedPieceEnum, expectedSideEnum);

                var actualPiece = _board.Tiles[expectedOnTile].Piece;

                Assert.AreEqual(expectedChessPiece.Colour, actualPiece.Colour);
                Assert.AreEqual(expectedChessPiece.PieceName, actualPiece.PieceName, $"Wrong piece at location {expectedOnTile}");
            }
        }
    }
}