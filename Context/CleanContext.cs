using Microsoft.EntityFrameworkCore;
using royaltjänstflytt.Models;
using System;

namespace royaltjänstflytt.Context
{
    public class CleanContext : DbContext
    {
        public CleanContext(DbContextOptions<CleanContext> options)
            : base(options)
        {
        }

        public DbSet<Move> Moves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships and other configurations here
            base.OnModelCreating(modelBuilder);
        }
    }
}
