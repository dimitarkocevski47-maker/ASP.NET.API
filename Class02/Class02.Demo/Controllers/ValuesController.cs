using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class02.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public new List<string> Get()
        {
            return new List<string> { "value1", "value2" };
        }

        [HttpGet("info")]
        public string GetInfo()
        {
            return "This is simple API controller that returns values.";
        }

        //HAS SAME HTTPMETHOD AND SAME ADDRESS!!! -> Will cause error while starting the API
        //The controller dosen't know how to make difference between Get() and GetString()
        //[HttpGet]
        //public string GetString()
        //{
        //    return "test";
        //}

        [HttpPost]
        public string Post()
        {
            return "OK";
        }

        [HttpGet("details/{id}")]
        public string GetById(int id) 
        {
            return $"value{id}";
        }
    }
}
