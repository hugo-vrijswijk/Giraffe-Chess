using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.DomainService.Command;

namespace GiraffeChess.DomainService.Service
{
    public class LogService : ILogService
    {
        private BusCommunicator BusCommunicator { get; set; }
        public LogService(BusCommunicator busCommunicator)
        {
            BusCommunicator = busCommunicator;
        }
        public void SendLog(string exchange,string routingKey,LogCommand command)
        {
            BusCommunicator.SendCommand(exchange,routingKey,command);
        }
    }
}
