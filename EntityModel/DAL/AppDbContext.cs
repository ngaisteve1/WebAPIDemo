﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CRUDDB")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
