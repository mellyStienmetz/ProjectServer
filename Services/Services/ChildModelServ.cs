using Services.Interfaces;
using Services.Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Azure;
using Entities.Entities;
using Repository.Repositories;

namespace Services.Services
{
    public class ChildModelServ : IChildModelServ
    {
        private readonly IChildRepository repository;
        private readonly IMapper mapper;
        public ChildModelServ(IChildRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ChildModel> Add(ChildModel entity)
        {
            return mapper.Map<ChildModel>(await repository.Add(mapper.Map<Child>(entity)));
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<List<ChildModel>> GetAll()
        {
            return mapper.Map<List<ChildModel>>(await repository.GetAll());
        }

        public async Task<ChildModel> GetById(int id)
        {
            return mapper.Map<ChildModel>(await repository.GetById(id));
        }

        public async Task<ChildModel> Update(ChildModel entity)
        {
            return mapper.Map<ChildModel>(await repository.Update( mapper.Map<Child>(entity)));
        }
    }
}
