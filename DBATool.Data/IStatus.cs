using DBATool.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBATool.Data
{
    public interface IStatus
    {

        Status Get(int id);
        void Add(Status newStatus);

        IEnumerable<Status> GetAll();

    }
}
