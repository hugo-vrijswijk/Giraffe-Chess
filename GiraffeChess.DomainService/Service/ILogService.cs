using GiraffeChess.DomainService.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService.Service
{
    public interface ILogService
    {
        void SendLog(string exchange, string routingKey, LogCommand command);
    }
}
