using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Repositories;
using Entities.Entities;
using Services.Model;

namespace Services
{
    public static  class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection service)
        {
            service.AddScoped<IPersonRepository, PersonRepository>();
            service.AddScoped<IChildRepository, ChildRepository>();
            MapperConfiguration config = new MapperConfiguration(
                conf => { conf.CreateMap<Person, PersonModel>().ReverseMap();
                    conf.CreateMap<Child, ChildModel>().ReverseMap();
                });
            IMapper mapper = config.CreateMapper();
            service.AddSingleton(mapper);
            

            service.AddDbContext<IDataSource, SQLDataSource>();

        }
    }
}
