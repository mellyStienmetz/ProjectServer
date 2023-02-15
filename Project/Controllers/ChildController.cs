using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildModelServ service;
        public ChildController(IChildModelServ service)
        {
            this.service = service;
        }

        // GET: api/<ChildController>
        [HttpGet]
        public async Task<List<ChildModel>> Get()
        {
            return await  service.GetAll();
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public async Task<ChildModel> GetById(int id)
        {
            return await service.GetById(id);
        }
        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChildModel> Post([FromBody] ChildModel child)
        {
            return await service.Add(child);
        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public async Task<ChildModel> Put(int id, [FromBody]ChildModel child)
        {
           return await service.Update(new ChildModel { Tz=child.Tz,FirstName=child.FirstName,DateOfBirth=child.DateOfBirth  });  
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
                await service.Delete(id);
        }
    }
}
