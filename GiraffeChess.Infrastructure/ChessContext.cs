using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Infrastructure.Entities;

namespace GiraffeChess.Infrastructure
{
    public class ChessContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }
        public ChessContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
