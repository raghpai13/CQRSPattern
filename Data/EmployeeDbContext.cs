﻿using CQRSPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSPattern.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
