using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeChess.DomainService.Command
{
    public class LogCommand
    {
        public string Body { get; set; }
        public string Server { get; set; }
        public DateTime? TimeLogged { get; set; }
    }
}
