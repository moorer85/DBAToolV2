using DBATool.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBATool.Data
{
    public interface IDatabase
    {
        Database Get(int id);
        void Add(Database newStatus);

        IEnumerable<Database> GetAll();
    }
}
