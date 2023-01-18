using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Model
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Board> Boards { get; set; }


        public string DbPath { get; }

        public TodoContext()
        {
            DbPath = "bin/Board.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");



    }
}