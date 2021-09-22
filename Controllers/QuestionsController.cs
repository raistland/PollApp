using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PollAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PollAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly PollDbContext pollContext;

        public QuestionsController(PollDbContext apiContext)
        {
            this.pollContext = apiContext;
        }
        // GET: api/<QuestionsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //GET api/<QuestionsController>/5
        [HttpGet("{id}")]
        public ActionResult<Question> Get(int id)
        {

            var questions = pollContext.GetQuestions().Where(k => k.QuestionID == id);
            if (questions is null) return NotFound();

            return questions.FirstOrDefault();

        }

        // POST api/<QuestionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuestionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuestionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        public List<Question> Get()
        {
            List<Question> categories = pollContext.GetQuestions();
            return (categories);
        }
    }
}
