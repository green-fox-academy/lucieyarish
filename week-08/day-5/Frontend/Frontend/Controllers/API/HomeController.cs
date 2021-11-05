using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Frontend.Models;
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

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            if (appendable is null)
            {
                return NotFound(new {error = "Appendable not found"});
            }

            return Ok(new {appended = appendable + "a"});
        }
        
        
        // POST api/<ValuesController>
        [HttpPost("/dountil/{operation}")]
        public IActionResult DoUntil([FromRoute]string operation, [FromBody]DoUntil input)
        {
            int num = input.until;
            switch (operation)
            {
                case "sum":
                    int sum = 0;
                    for (int i = 0; i < num; i++)
                    {
                        sum += i + 1;
                    }
                    return Ok(new {until = num, result = sum});
                case "factor":
                    int fact = 1;
                    for (int x = 0; x < num; x++)
                    {
                        fact *= (x + 1);
                    }
                    return Ok(new {until = num, result = fact});
                case null:
                    return BadRequest(new {error = "Please provide a title!"});
            }
            return Ok(new {error = "Please provide a title!"});
        }
        

            //
            // if ()
            // {
            //     return Ok(new {result = operation + 10});
            // }
            //
            // return BadRequest( new {error = "Please provide a number!"});
            // else if (operation == "factor")
            // {
            //     return Ok(new {result =})
            // }

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