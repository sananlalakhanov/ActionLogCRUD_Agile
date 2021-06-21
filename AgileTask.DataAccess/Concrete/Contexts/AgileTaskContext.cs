using AgileTask.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgileTask.DataAccess.Concrete.Contexts
{
    public class AgileTaskContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("Data Source=10.0.100.11/vmmstest.agilesolutions.local;PASSWORD=user123;PERSIST SECURITY INFO=True;USER ID=user123;");
                //opt=>opt.UseOracleSQLCompatibility("19.2.1.247"));
        }
        public DbSet<ActionLogger>  ActionLoggers { get; set; }
    }
}
