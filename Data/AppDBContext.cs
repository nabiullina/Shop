using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;

namespace Shop.Data {
    public class AppDbContext: DbContext {
        public AppDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
