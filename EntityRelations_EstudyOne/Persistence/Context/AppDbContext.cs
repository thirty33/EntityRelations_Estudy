using EntityRelations_EstudyOne.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations_EstudyOne.Persistence
{
    public class AppDbContext : DbContext
    {


        public DbSet <User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.FirstName).IsRequired().HasMaxLength(20);
            builder.Entity<User>().Property(p => p.Password).IsRequired();
            builder.Entity<User>().Property(p => p.LastName).IsRequired().HasMaxLength(20);

            builder.Entity<User>().HasData
            (
                new User { Id = 01 ,FirstName = "Joel", LastName = "Suarez", Password = "admin" } 
            );

            builder.Entity<Project>().ToTable("Projects");
            builder.Entity<Project>().HasKey(p => p.Id);
            builder.Entity<Project>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Project>().Property(p => p.UserForeingKey).IsRequired();
            builder.Entity<Project>().Property(p => p.Description).IsRequired().HasMaxLength(100);
            builder.Entity<Project>().Property(p => p.CreationDate).IsRequired();

            builder.Entity<Project>().HasData
            (
                new Project { Id = 01, Name = "Bingo75App", Description = "Builded with Xamarin and .net Framework", CreationDate = new DateTime(2019,5,14), UserForeingKey = 01 },
                new Project { Id = 02, Name = "SIIS", Description = "builded with php and jquery", CreationDate = new DateTime(2019,5,14), UserForeingKey = 01 },
                new Project { Id = 03, Name = "Jet set travel system", Description = "builded with vue.js and firebase", CreationDate = new DateTime(2019,5,14), UserForeingKey = 01 }
            );
        }
    }
}
