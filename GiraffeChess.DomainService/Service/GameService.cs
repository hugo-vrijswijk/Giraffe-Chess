using GiraffeChess.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService.Command;

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

        public Board Move(MoveCommand command)
        {
            var board = _boardRepository.Get(command.BoardId);
            board.Move(command.From, command.To);
            _boardRepository.Save(board);
            return board;
        }
    }
}
