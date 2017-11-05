using GiraffeChess.DomainService;
using System;
using Microsoft.EntityFrameworkCore;

namespace GiraffeChess.Test.Unit.Mock
{
    public class MockBoardRepository : IBoardRepository
    {
        public GiraffeChess.ApplicationService.Entities.ChessContext Context { get; }
        public DbContextOptions Options { get; } =
        new DbContextOptionsBuilder()
        .UseInMemoryDatabase("Boardinmemory")
        .Options;
        private GiraffeChess.ApplicationService.Mapper.BoardMapper BoardMapper { get; }

        public MockBoardRepository()
        {
            Context = new GiraffeChess.ApplicationService.Entities.ChessContext(Options);
            BoardMapper = new GiraffeChess.ApplicationService.Mapper.BoardMapper();
        }
        public GiraffeChess.Domain.Domain.Board Add(GiraffeChess.Domain.Domain.Board board)
        {
            var entity = BoardMapper.ToEntity(board);
            Context.Boards.Add(entity);
            Context.SaveChanges();

            return BoardMapper.FromEntity(entity);
        }
        public void InitializeDB()
        {
            using (var context = Context)
            {

                context.Database.EnsureCreated();
            }
        }

    }
}
