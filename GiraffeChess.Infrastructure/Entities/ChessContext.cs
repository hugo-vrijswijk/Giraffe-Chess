using Microsoft.EntityFrameworkCore;

namespace GiraffeChess.Infrastructure.Entities
{
    public class ChessContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardTile> Tiles { get; set; }
        public DbSet<ChessPiece> Pieces { get; set; }
        public ChessContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
