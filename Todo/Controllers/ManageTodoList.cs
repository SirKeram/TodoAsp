using System.Collections.Generic;
using System.Linq;
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
            return _context.TaskList.ToList();
        }

        public ActionResult<Task> GetSingleTaskToId(int id)
        {
            //TODO
        }

        public ActionResult<Task> AddTask(Task taskToAdd)
        {
            //TODO
        }

        public ActionResult<Task> UpdateTask(int id)
        {
            //TODO
        }

        public ActionResult<Task> DeleteTask(int id)
        {
            //TODO
        }
    }
}