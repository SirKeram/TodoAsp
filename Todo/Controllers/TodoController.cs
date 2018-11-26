using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    [Route("api/Todo")]
    public class TodoController : ControllerBase
    {
        private readonly ManageTodoList _manageTodoList;

        public TodoController(TodoContext context)
        {
            _manageTodoList = new ManageTodoList(context);
        }

        [HttpGet]
        public ActionResult<List<Task>> GetAllTask()
        {
            return _manageTodoList.GetAllTask();
        }

        [HttpGet("{id}")]
        public ActionResult<Task> GetSingleTaskById(int id)
        {
            return _manageTodoList.GetSingleTaskToId(id);
        }

        [HttpPost]
        public ActionResult<Task> AddTask([FromBody]Task taskToAdd)
        {
            return _manageTodoList.AddTask(taskToAdd);
        }

        [HttpPut("{id}")]
        public ActionResult<Task> UpdateTask(int id)
        {
            return _manageTodoList.UpdateTask(id);
        }

        [HttpDelete("{id}")]
        public ActionResult<Task> DeleteTask(int id)
        {
            return _manageTodoList.DeleteTask(id);
        }
        
    }
}