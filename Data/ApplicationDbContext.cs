using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrashCollectorProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
        {

        public
    ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }
        protected override void OnModeCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IndentityRole>()
                 .HasData(
                     new  IdentityRole
                     {
                         Name = "Admin",
                         NormalizedName = "ADMIN"
                     }
                 );
        }
    } 
}