using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService.Service;
using GiraffeChess.Test.Unit.Mock;
using GiraffeChess.WebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GiraffeChess.Test.Features.Implementations
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void SetupController()
        {
            var boardRepository = new InMemoryDb("FeatureTest").BoardRepository;
            var boardController = new BoardController(new BoardService(boardRepository));
            ScenarioContext.Current["BoardController"] = boardController;
        }
    }
}
