using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public interface IMangageListToDo
    {
        ActionResult<List<Task>> GetAllTask();
        ActionResult<Task> GetSingleTaskToId(int id);
        ActionResult<Task> AddTask(Task taskToAdd);
        ActionResult<Task> UpdateTask(int id);
        ActionResult<Task> DeleteTask(int id);
    }
}