using GiraffeChess.DomainService;
using System;
using GiraffeChess.Infrastructure.Entities;
using GiraffeChess.Infrastructure.Mapper;
using Microsoft.EntityFrameworkCore;
using Board = GiraffeChess.Domain.Domain.Board;

namespace GiraffeChess.Test.Unit.Mock
{
    public class MockBoardRepository : IBoardRepository
    {
        public DbContextOptions Options { get; } = 
            new DbContextOptionsBuilder()
            .UseInMemoryDatabase("Boardinmemory")
            .Options;
        private BoardMapper BoardMapper { get; }

        public MockBoardRepository()
        {
            BoardMapper = new BoardMapper(new BoardTileMapper(new ChessPieceMapper()));
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
            using (var context = new ChessContext(Options))
            {
                context.Boards.Add(entity);
                context.SaveChanges();

            }

            return BoardMapper.FromEntity(entity);
        }

        public Board Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Board board)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new database to mock later.
        /// </summary>
        public void InitializeDB()
        {
            using (var context = new ChessContext(Options))
            {

                context.Database.EnsureCreated();
            }
        }

    }
}
