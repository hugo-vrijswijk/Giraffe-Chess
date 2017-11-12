using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiraffeChess.DomainService.Command;
using GiraffeChess.DomainService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiraffeChess.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class BoardController : Controller
    {
        private static readonly string ControllerName = nameof(BoardController).Replace("Controller", string.Empty).ToLower();

        private IBoardService BoardService { get; }

        public BoardController(IBoardService boardService)
        {
            BoardService = boardService;
        }
        [HttpGet]
        public IActionResult NewGame()
        {
            var board = BoardService.NewGame();
            return Created($"{ControllerName}/{board.Id}", board);
        }

        [HttpPost]
        public IActionResult Move([FromBody] MoveCommand command)
        {
            return Ok(BoardService.Move(command));
        }
    }
}