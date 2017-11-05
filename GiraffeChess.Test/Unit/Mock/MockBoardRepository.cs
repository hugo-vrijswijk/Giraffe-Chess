using GiraffeChess.DomainService;
using System;
using Microsoft.EntityFrameworkCore;

namespace GiraffeChess.Test.Unit.Mock
{
    public class MockBoardRepository : IBoardRepository
    {
        public DbContextOptions Options { get; } =
        new DbContextOptionsBuilder()
        .UseInMemoryDatabase("Boardinmemory")
        .Options;
        private GiraffeChess.ApplicationService.Mapper.BoardMapper BoardMapper { get; }

        public MockBoardRepository()
        {
            BoardMapper = new GiraffeChess.ApplicationService.Mapper.BoardMapper();
            InitializeDB();
        }
        /// <summary>
        /// Add a new board to the database.
        /// </summary>
        /// <param name="board">Domain board</param>
        /// <returns></returns>
        public GiraffeChess.Domain.Domain.Board Add(GiraffeChess.Domain.Domain.Board board)
        {
            var entity = BoardMapper.ToEntity(board);
            using (var context = new GiraffeChess.ApplicationService.Entities.ChessContext(Options))
            {
                context.Boards.Add(entity);
                context.SaveChanges();

            }

            return BoardMapper.FromEntity(entity);
        }
        /// <summary>
        /// Create a new database to mock later.
        /// </summary>
        public void InitializeDB()
        {
            using (var context = new GiraffeChess.ApplicationService.Entities.ChessContext(Options) )
            {

                context.Database.EnsureCreated();
            }
        }

    }
}
