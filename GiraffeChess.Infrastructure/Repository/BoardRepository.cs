using System;
using GiraffeChess.DomainService;
using GiraffeChess.Infrastructure.Entities;
using GiraffeChess.Infrastructure.Mapper;
using Board = GiraffeChess.Domain.Domain.Board;

namespace GiraffeChess.Infrastructure.Repository
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

        public Board Get(int id)
        {
            return BoardMapper.FromEntity(Context.Boards.Find(id));
        }

        public void Save(Board board)
        {
            var eBoard = BoardMapper.ToEntity(board);
            var dbEntry = Context.Entry(eBoard);
            dbEntry.CurrentValues.SetValues(eBoard);
            Context.SaveChanges();
        }
    }
}
