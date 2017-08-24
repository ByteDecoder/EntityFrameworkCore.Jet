﻿using Microsoft.EntityFrameworkCore;

namespace EFCore.Jet.Integration.Test.Model74_ComplexTypeContained_Github9536
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options) : base(options) { }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<LessThanFriend> LessThanFriends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Friend>()
                .OwnsOne(_ => _.Address)
                .OwnsOne(_ => _.CityAddress1);
            modelBuilder.Entity<Friend>()
                .OwnsOne(_ => _.Address)
                .OwnsOne(_ => _.CityAddress2);
            modelBuilder.Entity<LessThanFriend>()
                .OwnsOne(_ => _.Address);
        }
    }
}
