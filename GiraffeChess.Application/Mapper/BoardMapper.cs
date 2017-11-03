using System;
using System.Collections.Generic;
using System.Text;
using GiraffeChess.Domain.Domain;
using GiraffeChess.DomainService.Mapper;
using Entities = GiraffeChess.Infrastructure.Entities;
namespace GiraffeChess.ApplicationService.Mapper
{
    public class BoardMapper : IBoardMapper
    {
        public Board FromEntity(object v)
        {
            throw new NotImplementedException();
        }
    }
}
