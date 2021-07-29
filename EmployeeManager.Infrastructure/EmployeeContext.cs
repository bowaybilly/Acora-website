using EmployeeManager.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EmployeeManager.Infrastructure
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public static string ConnectionString { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
             base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity => {
                entity.HasData(new List<Employee>() {
                  new Employee()
                  {
                    EmployeeNumber=1,
                    FirstName="John",
                    LastName="Doe",
                    Address="23 Fox lane London SE15 9PL",
                    City="London",
                    DateOfBirth=new DateTime(1980,10,05),
                    Department=Guid.NewGuid(),
                  },
                  new Employee()
                  {
                    EmployeeNumber=2,
                    FirstName="John",
                    LastName="Doe",
                    Address="23 Fox lane London SE15 9PL",
                    City="London",
                    DateOfBirth=new DateTime(1980,10,05),
                    Department=Guid.NewGuid(),
                  },
                  new Employee()
                  {
                    EmployeeNumber=3,
                    FirstName="John",
                    LastName="Doe",
                    Address="23 Fox lane London SE15 9PL",
                    City="London",
                    DateOfBirth=new DateTime(1980,10,05),
                    Department=Guid.NewGuid(),
                  },
                  new Employee()
                  {
                    EmployeeNumber=4,
                    FirstName="John",
                    LastName="Doe",
                    Address="23 Fox lane London SE15 9PL",
                    City="London",
                    DateOfBirth=new DateTime(1980,10,05),
                    Department=Guid.NewGuid(),
                  },
                });
                
            });
            modelBuilder.Entity<Department>(entity => {
                entity.HasData(new List<Department>() {
                  new Department(){ Id=Guid.NewGuid(), Name="Engineering"},
                  new Department(){ Id=Guid.NewGuid(), Name="Finance"},
                  new Department(){ Id=Guid.NewGuid(), Name="Human Resource"},
                  new Department(){ Id=Guid.NewGuid(), Name="Maintainence"},
                });

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
