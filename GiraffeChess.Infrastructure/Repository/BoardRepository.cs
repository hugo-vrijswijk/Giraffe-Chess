using System;
using GiraffeChess.ApplicationService.Entities;
using GiraffeChess.ApplicationService.Mapper;
using GiraffeChess.DomainService;
using Board = GiraffeChess.Domain.Domain.Board;

namespace GiraffeChess.ApplicationService.Repository
{
    public class BoardRepository : IBoardRepository
    {
        private ChessContext Context { get; }
        private BoardMapper BoardMapper { get; }

        public BoardRepository(ChessContext context, BoardMapper boardMapper)
        {
            Context = context;
            BoardMapper = boardMapper;
        }

        public Board Add(Board board)
        {
            var entity = BoardMapper.ToEntity(board);
            Context.Boards.Add(entity);
            Context.SaveChanges();

            return BoardMapper.FromEntity(entity);
        }
    }
}
