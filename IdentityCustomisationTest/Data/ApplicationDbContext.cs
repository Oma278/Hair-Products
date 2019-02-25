using System;
using System.Collections.Generic;
using System.Text;
using IdentityCustomisationTest.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCodesCW2.Model;

namespace IdentityCustomisationTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<ProjectCodesCW2.Model.Order> Order { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
    }
}
