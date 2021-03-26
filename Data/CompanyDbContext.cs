using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CompanyApplication.Models;

namespace CompanyApplication.Data
{
    public class CompanyDbContext : DbContext 
    {
       
            public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
            {
            }
           
            public DbSet<Director> Director { get; set; }
            public DbSet<Employees> Employee { get; set; }
            public DbSet<Candidates> Candidate { get; set; }
       


    }
}
