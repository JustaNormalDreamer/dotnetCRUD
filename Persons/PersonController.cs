using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using techlink.Persons;

namespace techlink.Controllers
{
    [ApiController]
    [Route("persons")]
    public class PersonController : Controller
    {
        private IPersonService _personService; 

        public PersonController(IPersonService personService) {
            _personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonResource>>> Get() 
        {
            var result = await _personService.all();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonResource>> Show(string id) {            
            return await _personService.show(id);
        }

        [HttpPost]       
        public async Task<ActionResult> Store(PersonRequest personDto) {
            Person person = new() {
                Name = personDto.name,
                email = personDto.email,
                password = personDto.password,
            };

            await _personService.store(person);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> update(string id, PersonRequest personDto)
        {
            Person person = new() {
                Name = personDto.name,
                email = personDto.email,
                password = personDto.password,
            };

            await _personService.update(id, person);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> destroy(string id)
        {
            await _personService.delete(id);
            return Ok();
        }
    }
}