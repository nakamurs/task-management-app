using System;
using System.ComponentModel.DataAnnotations;

/* Define the Task model */
namespace TaskManagementApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; } 
        
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; } // Required when adding a task
        public string? Description { get; set; } // Optional
        public DateTime? DueDate { get; set; } // Optional
        public bool IsCompleted { get; set; } = false; // Default to false
        
    }
}