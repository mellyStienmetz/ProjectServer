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
    public class PersonRepository : IPersonRepository
    {
        IDataSource dataSource;
        public PersonRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<Person> Add(Person entity)
        {
            dataSource.Person.Add(entity);
            await dataSource.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            dataSource.Person.Remove(entity);
            await dataSource.SaveChangesAsync();
        }

        public async Task<List<Person>> GetAll()
        {
            return await dataSource.Person.ToListAsync();
        }

        public async Task<Person> GetById(int id)
        {
            return await dataSource.Person.FindAsync(id);
        }

        public async Task<Person> Update(Person entity)
        {
            var updatePerson = dataSource.Person.Update(entity);
            await dataSource.SaveChangesAsync();
            return updatePerson.Entity;
        }
    }
}
