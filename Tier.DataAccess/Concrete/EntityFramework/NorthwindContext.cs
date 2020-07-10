﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Concrete.EntityFramework
{
    public class OADBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=OAEV\MSSQLSERVER2012;database=Blog;trusted_connection=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<Param> Param { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostDetail> PostDetail { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }

    }
}
