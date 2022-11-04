using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace WebApiDemo.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) {}

        public DbSet<ToDo>? ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasData(
                new ToDo { Id = 1, DueDate = DateTime.Today, Name = "Homework" },
                new ToDo { Id = 2, DueDate = DateTime.Today, Name = "Eat Dinner" }
            );
        }

    }
}
