using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission08_3_12.Models;

public partial class _413firstThingsContext : DbContext
{
    public _413firstThingsContext()
    {
    }

    public _413firstThingsContext(DbContextOptions<_413firstThingsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=413FirstThings.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(e => e.CategoryName, "IX_Categories_CategoryName").IsUnique();

            entity.Property(e => e.CategoryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TaskFix>(entity =>
        {
            entity.Property(e => e.TaskId).ValueGeneratedNever();
            entity.Property(e => e.Completed).HasColumnType("BOOLEAN");
            entity.Property(e => e.DueDate).HasColumnType("DATE");

            entity.HasOne(d => d.Category).WithMany(p => p.Tasks).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
