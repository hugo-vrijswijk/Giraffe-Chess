using GiraffeChess.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService
{
    public interface IBoardRepository
    {
        Board Add(Board board);
    }
}
