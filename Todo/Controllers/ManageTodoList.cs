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
            Task task = _context.TaskList.Find(id);

            if (task == null)
            {
                return new NotFoundResult();
            }

            return task;
        }

        public ActionResult<Task> AddTask(Task taskToAdd)
        {
            _context.TaskList.Add(taskToAdd);
            _context.SaveChanges();

            return GetSingleTaskToId(taskToAdd.id);
        }

        public ActionResult<Task> UpdateTask(int id, Task taskToUpdate)
        {
            Task taskToReplace = _context.TaskList.Find(id);

            if (taskToReplace == null)
            {
                return new NotFoundResult();
            }

            taskToReplace.name = taskToUpdate.name;
            taskToReplace.isComplete = taskToUpdate.isComplete;

            _context.TaskList.Update(taskToReplace);
            _context.SaveChanges();

            return new NoContentResult();
        }

        public ActionResult<Task> DeleteTask(int id)
        {
            Task taskToRemove = _context.TaskList.Find(id);

            if (taskToRemove == null)
            {
                return new NotFoundResult();
            }

            _context.TaskList.Remove(taskToRemove);
            _context.SaveChanges();
            
            return new NoContentResult();
        }
    }
}