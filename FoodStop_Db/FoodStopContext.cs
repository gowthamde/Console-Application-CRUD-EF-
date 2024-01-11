using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodStop_Db;

public partial class FoodStopContext : DbContext
{
    public FoodStopContext()
    {
    }

    public FoodStopContext(DbContextOptions<FoodStopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=REMOVER-DESKTOP\\SQLEXPRESS;Database=FoodStop;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
