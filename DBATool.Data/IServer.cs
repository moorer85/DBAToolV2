using DBATool.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBATool.Data
{
    public interface IServer
    {
       Server Get(int id);
       IEnumerable<Server> GetAll();
  
       void Add(Server newServer);
    }
}
