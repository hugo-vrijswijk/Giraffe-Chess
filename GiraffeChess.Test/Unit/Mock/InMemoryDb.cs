using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService;
using GiraffeChess.Infrastructure.Entities;
using GiraffeChess.Infrastructure.Mapper;
using GiraffeChess.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace GiraffeChess.Test.Unit.Mock
{
    internal class InMemoryDb
    {
        public IBoardRepository BoardRepository;

        public InMemoryDb()
        {
            var options = new DbContextOptionsBuilder()
                .UseInMemoryDatabase("Boardinmemory")
                .Options;
            var boardMapper = new BoardMapper(new BoardTileMapper(new ChessPieceMapper()));
            var context = new ChessContext(options);
            BoardRepository = new BoardRepository(context, boardMapper);

            context.Database.EnsureCreated();
        }
    }
}
