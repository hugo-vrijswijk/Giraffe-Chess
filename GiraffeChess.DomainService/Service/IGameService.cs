using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService.Command;

namespace GiraffeChess.DomainService.Service
{
    public interface IGameService
    {
        Board NewGame();
        Board Move(MoveCommand command);
    }
}
