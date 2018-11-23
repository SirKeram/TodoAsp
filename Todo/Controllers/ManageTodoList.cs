using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public class ManageTodoList : IMangageListToDo
    {
        private readonly TodoContext _context;
        
        public ManageTodoList(TodoContext context)
        {
            _context = context;
        }
        
        public ActionResult<List<Task>> GetAllTask()
        {
            //TODO
        }

        public ActionResult<Task> GetSingleTaskToId(int id)
        {
            //TODO
        }

        public IActionResult AddTask(Task taskToAdd)
        {
            //TODO
        }

        public IActionResult UpdateTask(int id)
        {
            //TODO
        }

        public IActionResult DeleteTask(int id)
        {
            //TODO
        }
    }
}