using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public  interface IDataSource
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DbSet<Person> Person { get; set; }
        DbSet<Child> Children { get; set; }
    }
}
