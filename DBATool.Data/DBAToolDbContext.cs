using DBATool.Data.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBATool.Data
{
    public class DBAToolDbContext : DbContext
    {
        public DBAToolDbContext(DbContextOptions options) : base(options)
        {
        }

        protected DBAToolDbContext()
        {
        }


        public virtual DbSet<Database> Databases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Server> Servers { get; set; }

        public virtual DbSet<Status> Statuses { get; set; }

    }
}
