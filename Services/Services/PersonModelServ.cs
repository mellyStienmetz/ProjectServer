using AutoMapper;
using Entities.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PersonModelServ : IPersonModelServ
    {
        IPersonRepository repository;
        IMapper mapper;
        public PersonModelServ(IPersonRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<PersonModel> Add(PersonModel entity)
        {
            return mapper.Map<PersonModel>(repository.Add(mapper.Map<Person>(entity)));
        }

        public async Task Delete(int id)
        {
           await repository.Delete(id);
        }

        public async Task<List<PersonModel>> GetAll()
        {
            return mapper.Map<List<PersonModel>>(await repository.GetAll());
        }

        public async Task<PersonModel> GetById(int id)
        {
            return mapper.Map<PersonModel>(await repository.GetById(id));
        }

        public async Task<PersonModel> Update(PersonModel entity)
        {
            return mapper.Map<PersonModel>(await repository.Update( mapper.Map<Person>(entity)));
        }
    }
}
