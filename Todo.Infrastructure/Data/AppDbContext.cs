using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;
using TodoApp.Infrastructure.Configurations;
//using TodoApp.Infrastructure.Configurations;

namespace TodoApp.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }//pass connection string from configuration/programe.cs

        //All these are tables which are entities in domain layer. this way we can access the database tables
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ToDoListConfiguration());
            modelBuilder.ApplyConfiguration(new ToDoItemConfiguration());
            base.OnModelCreating(modelBuilder); // Call to the base method
        }
        
    }
}