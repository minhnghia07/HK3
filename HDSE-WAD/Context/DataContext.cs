using HDSE_WAD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HDSE_WAD.Context
{
    public class DataContext: DbContext 
    {
        public DataContext() : base("T1907AEntities")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }

    }
}