using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Model;
using System.Linq.Expressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonModelServ service;

        public PersonController(IPersonModelServ service)
        {
            this.service = service;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await service.GetById(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async  Task<PersonModel> Post([FromBody] PersonModel person)
        {
           return await service.Add(person);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public async Task<PersonModel> Put(int id,[FromBody] PersonModel person)
        {
           return await service.Update(new PersonModel { children=person.children,
               FirstName=person.FirstName,
               FamilyName=person.FamilyName,
               Tz=person.Tz,
               Gender=person.Gender,
               HMO=person.HMO,
               DateOfBirth=person.DateOfBirth});
        }


        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }

    }
}
