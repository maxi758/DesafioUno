using Desafio_Uno.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Uno.Context
{
    class UserContext : DbContext
    {
        private const string schema = "user";
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=UsersDB;Integrated Security=True;";
        public UserContext()
        {

        }
        public UserContext( DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(schema);
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
    }
}
