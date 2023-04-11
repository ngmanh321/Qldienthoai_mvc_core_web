using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BTL_Web.Models;

public partial class QldienthoaiContext : DbContext
{
    public QldienthoaiContext()
    {
    }

    public QldienthoaiContext(DbContextOptions<QldienthoaiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chitietdonhang> Chitietdonhangs { get; set; }

    public virtual DbSet<Donhang> Donhangs { get; set; }

    public virtual DbSet<Hangsanxuat> Hangsanxuats { get; set; }

    public virtual DbSet<Hedieuhanh> Hedieuhanhs { get; set; }

    public virtual DbSet<Manhinh> Manhinhs { get; set; }

    public virtual DbSet<Nguoidung> Nguoidungs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=THUNGUYEN\\SQLEXPRESS;Initial Catalog=QLdienthoai;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Chitietdonhang>(entity =>
        {
            entity.HasKey(e => new { e.Madon , e.Masp });

            entity.ToTable("Chitietdonhang");

            entity.Property(e => e.Dongia).HasColumnType("decimal(18, 0)");


        });

        modelBuilder.Entity<Donhang>(entity =>
        {
            entity.HasKey(e => e.Madon);

            entity.ToTable("Donhang");

            entity.Property(e => e.Madon).ValueGeneratedNever();
            entity.Property(e => e.Ngaydat).HasColumnType("datetime");


            entity.HasOne(d => d.TenTkNavigation).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.TenTk)
                .HasConstraintName("FK_Donhang_Nguoidung");
        });

        modelBuilder.Entity<Hangsanxuat>(entity =>
        {
            entity.HasKey(e => e.Mahang);

            entity.ToTable("Hangsanxuat");

            entity.Property(e => e.Tenhang)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Hedieuhanh>(entity =>
        {
            entity.HasKey(e => e.Mahdh);

            entity.ToTable("Hedieuhanh");

            entity.Property(e => e.Tenhdh)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Manhinh>(entity =>
        {
            entity.HasKey(e => e.Mamanhinh);

            entity.ToTable("Manhinh");

            entity.Property(e => e.Mamanhinh).HasMaxLength(50);
            entity.Property(e => e.Tenmanhinh).HasMaxLength(50);
        });

        modelBuilder.Entity<Nguoidung>(entity =>
        {
            entity.HasKey(e => e.TenTk);

            entity.ToTable("Nguoidung");

            entity.Property(e => e.TenTk)
                .HasMaxLength(50)
                .HasColumnName("TenTK");
            entity.Property(e => e.LoaiTk)
                .HasMaxLength(50)
                .HasColumnName("LoaiTK");
            entity.Property(e => e.MatKhau).HasMaxLength(50);
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp);

            entity.ToTable("Sanpham");

            entity.Property(e => e.Anhbia).HasMaxLength(10);
            entity.Property(e => e.Camera).HasMaxLength(50);
            entity.Property(e => e.Chip).HasMaxLength(50);
            entity.Property(e => e.Giatien).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Mamanhinh).HasMaxLength(50);
            entity.Property(e => e.Mota).HasColumnType("ntext");
            entity.Property(e => e.Pin).HasMaxLength(50);
            entity.Property(e => e.Tensp).HasMaxLength(50);

            entity.HasOne(d => d.MahangNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Mahang)
                .HasConstraintName("FK_Sanpham_Hangsanxuat");

            entity.HasOne(d => d.MahdhNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Mahdh)
                .HasConstraintName("FK_Sanpham_Hedieuhanh");

            entity.HasOne(d => d.MamanhinhNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Mamanhinh)
                .HasConstraintName("FK_Sanpham_Manhinh");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
