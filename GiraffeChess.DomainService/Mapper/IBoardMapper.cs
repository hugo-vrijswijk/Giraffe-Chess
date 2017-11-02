using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.DomainService.Mapper
{
    public interface IBoardMapper
    {
        Board FromEntity(object v);
    }
}
