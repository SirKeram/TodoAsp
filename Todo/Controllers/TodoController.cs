using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    [Route("api/Todo")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Task>> GetAllTask()
        {
            
        }
        
        [HttpGet("{id}")]
        public ActionResult<Task> GetSingleTaskById(int id)
        {
            
        }

        [HttpPost]
        public IActionResult AddTask(Task taskToAdd)
        {
            
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id)
        {
            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            
        }
    }
}