using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using United_Youth_Orchestra_with_MVC.Models;

namespace United_Youth_Orchestra_with_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<United_Youth_Orchestra_with_MVC.Models.Instrument> Instrument { get; set; }
        public DbSet<United_Youth_Orchestra_with_MVC.Models.Schoolyear> Schoolyear { get; set; }
        public DbSet<United_Youth_Orchestra_with_MVC.Models.Member> Member { get; set; }
    }
}
