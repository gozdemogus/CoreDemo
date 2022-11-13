using System;
using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
	public class Context:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=master2;MultipleActiveResultSets=true;User=SA;Password=MyPass@word;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

