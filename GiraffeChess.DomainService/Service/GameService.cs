using GiraffeChess.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService.Service
{
    public class GameService : IGameService
    {
        private readonly IBoardRepository _boardRepository;

        public GameService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public Board NewGame()
        {
            var board = new Board();
            return _boardRepository.Add(board);
        }
    }
}
