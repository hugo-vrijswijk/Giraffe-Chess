using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService.Service
{
    public class GameService : IGameService
    {
        private readonly IBoardRepository boardRepository;

        public GameService(IBoardRepository boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        public Board NewGame()
        {
            return boardRepository.NewGame();
        }
    }
}
