using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.ApplicationService.Entities
{
    public class Board
    {
        public int? Id { get; set; }
        public Side Turn { get; set; }
        public List<BoardTile> Tiles { get; set; }
    }
}
