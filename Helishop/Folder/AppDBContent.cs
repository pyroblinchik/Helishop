﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helishop.Folder.Models;
using Microsoft.EntityFrameworkCore;

namespace Helishop.Folder
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Helicopter> Helicopter { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
