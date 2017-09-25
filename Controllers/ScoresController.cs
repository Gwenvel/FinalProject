using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/Scores")]
    public class ScoresController : Controller
    {
        // GET api/scores
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "score1", "score2" };
        }

        // GET api/scores/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "score";
        }

        // POST api/scores
        [HttpPost]
        public void Post([FromBody]string score)
        {
        }

        // PUT api/scores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string score)
        {
        }

        // DELETE api/scores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
