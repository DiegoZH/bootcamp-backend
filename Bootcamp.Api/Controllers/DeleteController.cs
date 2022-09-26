using Bootcamp.Model;
using Bootcamp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public DeleteController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromBody] Person person)
        {
            var result = await _personRepository.Delete(person);
            return Ok(result);
        }


    }
}
