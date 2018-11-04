using Eoh_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eoh_DataService
{
    public class EohDbContext : DbContext
    {
        public EohDbContext()
           : base("EOHModel"){}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}