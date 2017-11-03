using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;

namespace GiraffeChess.DomainService.Service
{
    public interface IGameService
    {
        Board NewGame();
    }
}
