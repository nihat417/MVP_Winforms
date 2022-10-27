using Microsoft.EntityFrameworkCore;
using Source.Models;
using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace Source.Repositories.Contexts;

public class MyDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder, Student Name)
    {
        optionsBuilder.UseSqlServer("Homework");

        

        base.OnConfiguring(optionsBuilder);
    }


    public System.Data.Entity.DbSet<Student>? Students { get; set; }
}