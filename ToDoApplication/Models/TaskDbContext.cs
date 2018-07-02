using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoApplication.Models
{
    public class TaskDbContext : DbContext
    {
        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
