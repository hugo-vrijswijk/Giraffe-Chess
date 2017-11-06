using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.ApplicationService.Entities
{
    public class BoardTile
    {
        public int? Id { get; set; }
        public string Position { get; set; }
        public ChessPiece ChessPiece { get; set; }
    }
}
