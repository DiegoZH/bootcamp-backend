using Bootcamp.Model;
using Bootcamp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public UpdateController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Person person)
        {
            var result = await _personRepository.Update(person);
            return Ok(result);
        }


    }
}
