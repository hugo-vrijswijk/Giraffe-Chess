using System;
using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService;
using GiraffeChess.Infrastructure;

namespace GiraffeChess.ApplicationService
{
    public class BoardRepository : IBoardRepository
    {
        private ChessContext Context { get; }

        public BoardRepository(ChessContext context)
        {
            Context = context;
        }

        public Board Add(Board board)
        {
            //Context.Boards.Add(board);
            Context.SaveChanges();
            throw new NotImplementedException();
        }
    }
}
