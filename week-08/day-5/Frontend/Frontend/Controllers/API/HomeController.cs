using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Frontend.Models;
using Frontend.Models.Entities;
using Frontend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers.API
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private LogService LogService { get; }
        private SithReverserService SithReverserService { get; }

        public HomeController(LogService service, SithReverserService sithService)
        {
            LogService = service;
            SithReverserService = sithService;
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            return File("index.html", "text/html");
        }
        
        [HttpGet("doubling")]
        public IActionResult GetDouble([FromQuery] int? input)
        {
            LogService.AddLog("doubling", $"input={input}");
            if (input is null)
            {
                return Ok(new {error = "Please provide an input!"});
            }

            return Ok(new {received = input, result = input * 2});
        }

        [HttpGet("greeter")]
        public IActionResult Greet([FromQuery] string name, string title)
        {
            LogService.AddLog("greeter", $"name={name}&title={title}");
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

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            LogService.AddLog($"appenda/{appendable}", appendable);
            if (appendable is null)
            {
                return NotFound(new {error = "Appendable not found"});
            }

            return Ok(new {appended = appendable + "a"});
        }
        
        [HttpPost("dountil/{operation}")]
        public IActionResult DoUntil([FromRoute] string operation, [FromBody] DoUntil input)
        {
            LogService.AddLog($"dountil/{operation}", $"{operation}, until={input.until}");
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

        [HttpPost("arrays")]
        public IActionResult HandleArrays([FromBody] ArrayHandler input)
        {
            LogService.AddLog("arrays", $"numbers={string.Join(",", input.Numbers)}&operation={input.Operation}");
            string myOperation = input.Operation;
            int[] myNumbers = input.Numbers;
            int myResult = 0;
            int myResult2 = 1;

            if (string.IsNullOrEmpty(myOperation) || myNumbers is null)
            {
                return NotFound(new {error = "Please provide what to do with the numbers!"});
            }

            switch (myOperation)
            {
                case "sum":
                    foreach (var num in myNumbers)
                    {
                        myResult += num;
                    }
                    return Ok(new {result = myResult});
                case "multiply":
                    foreach (var num in myNumbers)
                    {
                        myResult2 *= num;
                    }
                    return Ok(new {result = myResult2});
                case "double":
                    for (int i = 0; i < myNumbers.Length; i++)
                    {
                        myNumbers[i] = myNumbers[i] * 2;
                    }
                    return Ok(new {result = myNumbers});
            }
            return Ok();
        }

        [HttpGet("log")]
        public IActionResult LogEntries()
        {
            var allLogs = LogService.DisplayLogs();
            return Ok(new {entries = allLogs, entries_count = allLogs.Count});
        }

        [HttpPost("sith")]
        public IActionResult ReverseSith([FromBody] SithReverser text)
        {
            var sentence = text.TextToReverse;
            var reversedSentence = SithReverserService.ReverseText(sentence);
            return Ok(new { sith_text = reversedSentence});
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