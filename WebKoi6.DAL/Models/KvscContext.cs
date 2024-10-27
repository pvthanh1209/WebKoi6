using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WebKoi6.DAL.Models;

public partial class KvscContext : DbContext
{
    public KvscContext()
    {
    }

    public KvscContext(DbContextOptions<KvscContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bacsi> Bacsis { get; set; }

    public virtual DbSet<Banggia> Banggias { get; set; }

    public virtual DbSet<Chuandoanbenhcakoi> Chuandoanbenhcakois { get; set; }

    public virtual DbSet<Chuandoantinhtrangnuoc> Chuandoantinhtrangnuocs { get; set; }

    public virtual DbSet<Dichvuthuy> Dichvuthuys { get; set; }

    public virtual DbSet<Doitac> Doitacs { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Lichhen> Lichhens { get; set; }

    public virtual DbSet<Thanhtuu> Thanhtuus { get; set; }

    public virtual DbSet<Thuoc> Thuocs { get; set; }

    public virtual DbSet<Tintuc> Tintucs { get; set; }

    public virtual DbSet<Trungtam> Trungtams { get; set; }
    public virtual DbSet<Taikhoan> Taikhoans { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Bacsi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.ToTable("bacsi");

            entity.Property(e => e.Availability)
                .HasDefaultValueSql("'Rảnh'")
                .HasColumnType("enum('Rảnh','Bận')");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.TenBacSi).HasMaxLength(255);
        });

        modelBuilder.Entity<Banggia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("banggia");

            entity.Property(e => e.Gia).HasPrecision(10, 2);
            entity.Property(e => e.TenDichVu).HasMaxLength(100);
        });

        modelBuilder.Entity<Chuandoanbenhcakoi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chuandoanbenhcakoi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChuanDoan).HasMaxLength(100);
            entity.Property(e => e.DauHieu).HasColumnType("text");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HinhThucDieuTri).HasColumnType("text");
            entity.Property(e => e.NgayThang).HasMaxLength(10);
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            entity.Property(e => e.TenLoaiCaKoi).HasMaxLength(100);
        });

        modelBuilder.Entity<Chuandoantinhtrangnuoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chuandoantinhtrangnuoc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoCuongNuoc).HasPrecision(5, 2);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.NhietDo).HasPrecision(4, 1);
            entity.Property(e => e.Ph)
                .HasPrecision(3, 1)
                .HasColumnName("PH");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            entity.Property(e => e.TinhTrang).HasColumnType("text");
        });

        modelBuilder.Entity<Dichvuthuy>(entity =>
        {
            entity.HasKey(e => e.MaDichVu).HasName("PRIMARY");

            entity.ToTable("dichvuthuy");

            entity.Property(e => e.MoTa).HasColumnType("text");
            entity.Property(e => e.TenDichVu).HasMaxLength(100);
        });

        modelBuilder.Entity<Doitac>(entity =>
        {
            entity.HasKey(e => e.MaDoiTac).HasName("PRIMARY");

            entity.ToTable("doitac");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.GhiChu).HasColumnType("text");
            entity.Property(e => e.LoaiHinhHopTac).HasMaxLength(50);
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenDoiTac).HasMaxLength(100);
            entity.Property(e => e.Website).HasMaxLength(100);
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.HasKey(e => e.Faqid).HasName("PRIMARY");

            entity.ToTable("faq");

            entity.Property(e => e.Faqid).HasColumnName("FAQID");
            entity.Property(e => e.CauHoi).HasColumnType("text");
            entity.Property(e => e.CauTraLoi).HasColumnType("text");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PRIMARY");

            entity.ToTable("feedback");

            entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");
            entity.Property(e => e.BinhLuan).HasColumnType("text");
            entity.Property(e => e.DanhGia).HasColumnType("enum('Tệ','Trung bình','Khá','Tốt')");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.ToTable("khachhang");
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<Lichhen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lichhen");

            entity.Property(e => e.HomeVisit)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.NgayHen).HasColumnType("datetime");
            entity.Property(e => e.TenBacSi).HasMaxLength(100);
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Thanhtuu>(entity =>
        {
            entity.HasKey(e => e.MaThanhTuu).HasName("PRIMARY");

            entity.ToTable("thanhtuu");

            entity.Property(e => e.GhiChu).HasColumnType("text");
            entity.Property(e => e.MoTa).HasColumnType("text");
            entity.Property(e => e.TenThanhTuu).HasMaxLength(255);
        });

        modelBuilder.Entity<Thuoc>(entity =>
        {
            entity.HasKey(e => e.MaThuoc).HasName("PRIMARY");

            entity.ToTable("thuoc");

            entity.Property(e => e.CongDung).HasColumnType("text");
            entity.Property(e => e.GhiChu).HasColumnType("text");
            entity.Property(e => e.Gia).HasPrecision(10, 2);
            entity.Property(e => e.LieuLuong).HasMaxLength(100);
            entity.Property(e => e.TenThuoc).HasMaxLength(255);
        });

        modelBuilder.Entity<Tintuc>(entity =>
        {
            entity.HasKey(e => e.MaTinTuc).HasName("PRIMARY");

            entity.ToTable("tintuc");

            entity.Property(e => e.NoiDung).HasColumnType("text");
            entity.Property(e => e.TacGia).HasMaxLength(100);
            entity.Property(e => e.TieuDe).HasMaxLength(255);
        });

        modelBuilder.Entity<Trungtam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("trungtam");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Hotline).HasMaxLength(15);
            entity.Property(e => e.MoTa).HasColumnType("text");
            entity.Property(e => e.TenTrungTam).HasMaxLength(100);
        });
        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.ToTable("taikhoan");
            entity.Property(e => e.FullName).HasMaxLength(500);
            entity.Property(e => e.Username).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
