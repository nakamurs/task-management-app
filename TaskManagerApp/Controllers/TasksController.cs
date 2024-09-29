using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using TaskManagementApp.Models;

/* Handle the logic for CRUD operations */
namespace TaskManagementApp.Controllers
{
    public class TasksController : Controller
    {
        private static List<TaskItem> tasks = new List<TaskItem>();
        private static int tid = 0;

        // GET: Tasks
        public IActionResult Index()
        {
            // Sort by the DueDate
            tasks = tasks.OrderBy(t => t.DueDate.HasValue ? 0 : 1).ThenBy(t => t.DueDate).ToList();
            return View(tasks);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            // show message if the DueDate is in the past
            if (task.DueDate.HasValue && task.DueDate < DateTime.Today)
            {
                ModelState.AddModelError("DueDate", "Due Date cannot be in the past.");
            }

            if (ModelState.IsValid) // if the Title is not empty
            {
                task.Id = tid;
                tid++;
                tasks.Add(task);
                return RedirectToAction(nameof(Index)); // go back to Index
            }
            return View(task); // return the validation message when invalid
        }

        // GET: Tasks/Edit/{id}
        public IActionResult Edit(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Tasks/Edit/{id}
        [HttpPost]
        public IActionResult Edit(TaskItem task)
        {
            // show message if the DueDate is in the past
            if (task.DueDate.HasValue && task.DueDate < DateTime.Today)
            {
                ModelState.AddModelError("DueDate", "Due Date cannot be in the past.");
            }

            if (ModelState.IsValid)
            {
                var existingTask = tasks.Find(t => t.Id == task.Id);
                if (existingTask != null){
                    existingTask.Title = task.Title;
                    existingTask.Description = task.Description;
                    existingTask.IsCompleted = task.IsCompleted;
                    existingTask.DueDate = task.DueDate;
                }
                return RedirectToAction(nameof(Index)); // go back to Index
            }
            return View(task);
        }

        // GET : Tasks/Delete/{id}
        public IActionResult Delete(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST : Tasks/Delete/{id}
        [HttpPost]
        public IActionResult DeleteConfirmed(int id) 
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
            }
            return RedirectToAction(nameof(Index));
        }        

        // Toggle the completion status
        [HttpPost]
        public IActionResult ToggleCompletion(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
            }
            
            return RedirectToAction(nameof(Index)); 
        }
    }
}
