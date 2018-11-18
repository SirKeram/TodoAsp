using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoController : Controller
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