using Bootcamp.Model;
using Bootcamp.Queries.DocumentType;
using Bootcamp.Queries.PersonRead;
using Bootcamp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonReadController : ControllerBase
    {
        private readonly IPersonQueries _documentTypeQueries;

        public PersonReadController(IPersonQueries documentTypeQueries)
        {
            _documentTypeQueries = documentTypeQueries;
        }

        [HttpGet]
        [Route("Read")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _documentTypeQueries.GetAll();
            return Ok(result);
        }
    }
}