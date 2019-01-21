using DBATool.Data;
using DBATool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DBATool.Service
{
    public class ServerService : IServer
    {

        private readonly DBAToolDbContext _context;

        public ServerService(DBAToolDbContext context)
        {

            _context = context;
        }

        public void Add(Server newServer)
        {
            _context.Add(newServer);
            _context.SaveChanges();

        }

        public Server Get(int id)
        {
            return _context.Servers.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Server> GetAll()
        {
            return _context.Servers;
        }

       
    }
}
