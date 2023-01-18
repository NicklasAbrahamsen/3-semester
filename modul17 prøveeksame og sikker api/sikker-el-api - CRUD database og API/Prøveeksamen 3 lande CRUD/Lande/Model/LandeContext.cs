// LandeContext.cs
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class LandeContext : DbContext
    {
        public DbSet<Land> Land { get; set; }
        public string DbPath { get; }

        public LandeContext()
        {
            DbPath = "bin/Land.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Land>().ToTable("Land");
            modelBuilder.Entity<Land>().HasKey(l => l.LandKodeId);
        }
    }
}