using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class02.NotesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        // GET: https://localhost:[port]/api/notes
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(StaticDb.SimpleNotes);
        }

        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= StaticDb.SimpleNotes.Count)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = $"Note with id {id} was not found."
                });
            }
            return Ok(StaticDb.SimpleNotes[id]);
        }
    }
}
