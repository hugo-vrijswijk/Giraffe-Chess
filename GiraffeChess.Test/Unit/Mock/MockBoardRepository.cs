using GiraffeChess.DomainService;
using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.Test.Unit.Mock
{
    public class MockBoardRepository : IBoardRepository
    {
        public Board Add(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
