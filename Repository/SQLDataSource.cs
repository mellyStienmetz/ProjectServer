using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SQLDataSource : DbContext, IDataSource
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B5S1T71;Initial Catalog=ProjectRegister;Integrated Security=True;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
          protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=DESKTOP-B5S1T71;Initial Catalog=ProjectRegister;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Person> Person { get ; set ; }
        public DbSet<Child> Children { get ; set ; }

       
    }
}
