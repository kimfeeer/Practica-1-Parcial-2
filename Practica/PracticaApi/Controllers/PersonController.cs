using System.Collections;
using Microsoft.AspNetCore.Mvc;
using PracticaApi.Repositories;
using PracticaApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        } 
    }
}