using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasOne(t => t.Asignee).WithMany(t => t.Todos).HasForeignKey(t => t.AsigneeId);
        }
       public DbSet<ToDo>Todo { get; set;}
       public DbSet<Asignee> Asignees { get; set;}
    
    }
}
