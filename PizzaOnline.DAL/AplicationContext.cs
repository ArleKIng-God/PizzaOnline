﻿using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline.DAL
{
    public class AplicationContext : DbContext
    {
        //public DbSet<Order> Orders { get; set; }
        public DbSet<AspNetUsers> AspNetUser { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Pizzeria> Pizzeria { get; set; }
        public AplicationContext(DbContextOptions<AplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzaOnline;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(p => p.AspNetUser)
                .WithMany(t => t.Orders);

            modelBuilder.Entity<Order>()
               .HasOne(p => p.Delivery)
               .WithMany(t => t.Orders);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Pizza)
                .WithMany(t => t.Orders);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Pizzeria)
                .WithMany(t => t.Orders);

            modelBuilder.Entity<Ingredients>()
                .HasOne(p => p.PizzaIngreedients)
                .WithMany(t => t.Ingredients);
        }
    }
}
