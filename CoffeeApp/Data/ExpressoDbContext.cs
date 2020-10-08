﻿using CoffeeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeApp.Data
{
    public class ExpressoDbContext:DbContext
    {
        public ExpressoDbContext(DbContextOptions<ExpressoDbContext>options):base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}