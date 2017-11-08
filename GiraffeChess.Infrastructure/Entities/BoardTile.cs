namespace GiraffeChess.Infrastructure.Entities
{
    public class BoardTile
    {
        public int? Id { get; set; }
        public string Position { get; set; }
        public ChessPiece ChessPiece { get; set; }
    }
}
