using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService.Command
{
    public class MoveCommand
    {
        public int BoardId { get; }
        public string From { get; }
        public string To { get; }

        public MoveCommand(int boardId, string @from, string to)
        {
            BoardId = boardId;
            From = from;
            To = to;
        }
    }
}
