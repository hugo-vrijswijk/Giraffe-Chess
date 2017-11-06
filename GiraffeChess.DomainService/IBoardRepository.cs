using GiraffeChess.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService
{
    public interface IBoardRepository
    {
        Board Add(Board board);
        Board Get(int id);
        void Save(Board board);
    }
}
