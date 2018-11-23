using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public interface IMangageListToDo
    {
        ActionResult<List<Task>> GetAllTask();
        ActionResult<Task> GetSingleTaskToId(int id);
        IActionResult AddTask(Task taskToAdd);
        IActionResult UpdateTask(int id);
        IActionResult DeleteTask(int id);
    }
}