using System;
using ToDoApplication.Models.Enums;

namespace ToDoApplication.Models
{
    public class TaskEntity
    {
        public int ID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDesc { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public bool Completed { get; set; }
    }
}
