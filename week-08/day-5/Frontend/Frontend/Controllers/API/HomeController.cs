using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers.API
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            return File("index.html", "text/html");
        }

        // GET api/<ValuesController>/5
        [HttpGet("/doubling")]
        public IActionResult GetDouble([FromQuery] int? input)
        {
            if (input is null)
            {
                return Ok(new { error = "Please provide an input!"});
            }
            return Ok(new {received = input, result = input * 2});
        }

        [HttpGet("/greeter")]
        public IActionResult Greet([FromQuery] string name, string title)
        {
            if (name is null)
            {
                return BadRequest(new {error = "Please provide a name and a title!"});
            }
            if (title is null)
            {
                return BadRequest(new {error = "Please provide a title!"});
            }
            //
            // if (name is null && title is null)
            // {
            //     return BadRequest(new {error = "Please provide a name and title!"});
            // }

            return Ok(new {welcome_message = $"Oh, hi there {name}, my dear {title}!"});
        }
        
        [HttpGet("/appenda")]
        public IActionResult AppendA()
        
        
        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}