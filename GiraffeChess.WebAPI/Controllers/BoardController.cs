using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiraffeChess.DomainService.Command;
using GiraffeChess.DomainService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dag37.MQ.Lib;

namespace GiraffeChess.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class BoardController : Controller
    {
        private static readonly string ControllerName = nameof(BoardController).Replace("Controller", string.Empty).ToLower();

        private IBoardService BoardService { get; }
        private ILogService Logger { get; set; }
        public BoardController(IBoardService boardService,ILogService logger)
        {
            BoardService = boardService;
            Logger = logger;
        }
        [HttpGet]
        [Event("Chess", "Chess.NewGame")]
        public IActionResult NewGame()
        {
            var board = BoardService.NewGame();
            return Created($"{ControllerName}/{board.Id}", board);
        }
        [HttpPost]
        [Event("Chess","Chess.Move")]
        public IActionResult Move(MoveCommand command)
        {
            var logCommand = new LogCommand
            {
                Body = command.BoardId.ToString(),
                Server = "localhost",
                TimeLogged = DateTime.Now
            };
            Logger.SendLog("Events", "audit.Move", logCommand);
            return Ok(BoardService.Move(command));
        }
    }
}