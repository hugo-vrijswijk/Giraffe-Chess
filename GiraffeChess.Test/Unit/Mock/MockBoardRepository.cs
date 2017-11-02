using GiraffeChess.DomainService;
using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.Test.Unit.Mock
{
    class MockBoardRepository : IBoardRepository
    {
        public Board NewGame()
        {
            return new Board { Id = 1 };
        }
    }
}
