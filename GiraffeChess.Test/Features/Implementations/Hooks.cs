using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService.Service;
using GiraffeChess.Test.Unit.Mock;
using GiraffeChess.WebAPI.Controllers;
using TechTalk.SpecFlow;

namespace GiraffeChess.Test.Features.Implementations
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void SetupController()
        {
            var boardController = new BoardController(new GameService(new MockBoardRepository()));
            ScenarioContext.Current["BoardController"] = boardController;
        }
    }
}
