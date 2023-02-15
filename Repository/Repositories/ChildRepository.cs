using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ChildRepository :IChildRepository
    {
        IDataSource dataSource;
        public ChildRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<Child> Add(Child entity)
        {
            dataSource.Children.Add(entity);
            await dataSource.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            dataSource.Children.Remove(entity);
            await dataSource.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAll()
        {
            return await dataSource.Children.ToListAsync();
        }

        public async Task<Child> GetById(int id)
        {
            return await dataSource.Children.FindAsync(id);
        }

        public async Task<Child> Update(Child entity)
        {
          var updateChild=dataSource.Children.Update(entity);
            await dataSource.SaveChangesAsync();
            return updateChild.Entity;
        }
    }
}
