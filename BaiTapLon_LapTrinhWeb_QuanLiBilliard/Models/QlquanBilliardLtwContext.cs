using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaiTapLon_LapTrinhWeb_QuanLiBilliard.Models;

public partial class QlquanBilliardLtwContext : DbContext
{
    public QlquanBilliardLtwContext()
    {
    }

    public QlquanBilliardLtwContext(DbContextOptions<QlquanBilliardLtwContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<Dichvu> Dichvus { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadondv> Hoadondvs { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Khuvuc> Khuvucs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phienchoi> Phienchois { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database= QLQuanBilliard_LTW;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.Idban).HasName("PK__BAN__9367225E5FE23221");

            entity.ToTable("BAN");

            entity.Property(e => e.Idban)
                .HasMaxLength(50)
                .HasColumnName("IDBAN");
            entity.Property(e => e.Giatien)
                .HasColumnType("money")
                .HasColumnName("GIATIEN");
            entity.Property(e => e.Idkhu)
                .HasMaxLength(50)
                .HasColumnName("IDKHU");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.IdkhuNavigation).WithMany(p => p.Bans)
                .HasForeignKey(d => d.Idkhu)
                .HasConstraintName("FK__BAN__IDKHU__628FA481");
        });

        modelBuilder.Entity<Dichvu>(entity =>
        {
            entity.HasKey(e => e.Iddv).HasName("PK__DICHVU__B87DB8EA84E32E80");

            entity.ToTable("DICHVU");

            entity.Property(e => e.Iddv)
                .HasMaxLength(50)
                .HasColumnName("IDDV");
            entity.Property(e => e.Giatien)
                .HasColumnType("money")
                .HasColumnName("GIATIEN");
            entity.Property(e => e.Hienthi).HasColumnName("HIENTHI");
            entity.Property(e => e.Loaidv)
                .HasMaxLength(50)
                .HasColumnName("LOAIDV");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Tendv)
                .HasMaxLength(50)
                .HasColumnName("TENDV");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Idhd).HasName("PK__HOADON__B87C1A07B02A35C8");

            entity.ToTable("HOADON");

            entity.Property(e => e.Idhd)
                .HasMaxLength(50)
                .HasColumnName("IDHD");
            entity.Property(e => e.Idkh)
                .HasMaxLength(50)
                .HasColumnName("IDKH");
            entity.Property(e => e.Idnv)
                .HasMaxLength(50)
                .HasColumnName("IDNV");
            entity.Property(e => e.Idphien)
                .HasMaxLength(50)
                .HasColumnName("IDPHIEN");
            entity.Property(e => e.Ngaylap)
                .HasColumnType("datetime")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Tongtien)
                .HasColumnType("money")
                .HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.IdkhNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idkh)
                .HasConstraintName("FK__HOADON__IDKH__6A30C649");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK__HOADON__IDNV__6B24EA82");

            entity.HasOne(d => d.IdphienNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idphien)
                .HasConstraintName("FK__HOADON__IDPHIEN__693CA210");
        });

        modelBuilder.Entity<Hoadondv>(entity =>
        {
            entity.HasKey(e => new { e.Idhd, e.Iddv }).HasName("PK__HOADONDV__03FBC1895EC4D1D4");

            entity.ToTable("HOADONDV");

            entity.Property(e => e.Idhd)
                .HasMaxLength(50)
                .HasColumnName("IDHD");
            entity.Property(e => e.Iddv)
                .HasMaxLength(50)
                .HasColumnName("IDDV");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

            entity.HasOne(d => d.IddvNavigation).WithMany(p => p.Hoadondvs)
                .HasForeignKey(d => d.Iddv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONDV__IDDV__6EF57B66");

            entity.HasOne(d => d.IdhdNavigation).WithMany(p => p.Hoadondvs)
                .HasForeignKey(d => d.Idhd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONDV__IDHD__6E01572D");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Idkh).HasName("PK__KHACHHAN__B87DC1A7F00A82F9");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Idkh)
                .HasMaxLength(50)
                .HasColumnName("IDKH");
            entity.Property(e => e.Dchi)
                .HasMaxLength(100)
                .HasColumnName("DCHI");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Sodt)
                .HasMaxLength(10)
                .HasColumnName("SODT");
        });

        modelBuilder.Entity<Khuvuc>(entity =>
        {
            entity.HasKey(e => e.Idkhu).HasName("PK__KHUVUC__939914D966718EDD");

            entity.ToTable("KHUVUC");

            entity.Property(e => e.Idkhu)
                .HasMaxLength(50)
                .HasColumnName("IDKHU");
            entity.Property(e => e.Tenkhu)
                .HasMaxLength(50)
                .HasColumnName("TENKHU");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Idnv).HasName("PK__NHANVIEN__B87DC9B20F43EFB7");

            entity.ToTable("NHANVIEN");

            entity.HasIndex(e => e.Cccd, "UQ__NHANVIEN__A955A0AA02813BD1").IsUnique();

            entity.Property(e => e.Idnv)
                .HasMaxLength(50)
                .HasColumnName("IDNV");
            entity.Property(e => e.Cccd)
                .HasMaxLength(15)
                .HasColumnName("CCCD");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Hienthi).HasColumnName("HIENTHI");
            entity.Property(e => e.Hotennv)
                .HasMaxLength(50)
                .HasColumnName("HOTENNV");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(50)
                .HasDefaultValue("12345678")
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Nghiviec)
                .HasDefaultValue(true)
                .HasColumnName("NGHIVIEC");
            entity.Property(e => e.Quyenadmin).HasColumnName("QUYENADMIN");
            entity.Property(e => e.Sodt)
                .HasMaxLength(20)
                .HasColumnName("SODT");
            entity.Property(e => e.Tendangnhap)
                .HasMaxLength(50)
                .HasDefaultValue("nv00")
                .HasColumnName("TENDANGNHAP");
        });

        modelBuilder.Entity<Phienchoi>(entity =>
        {
            entity.HasKey(e => e.Idphien).HasName("PK__PHIENCHO__9CAAE3C05734C465");

            entity.ToTable("PHIENCHOI");

            entity.Property(e => e.Idphien)
                .HasMaxLength(50)
                .HasColumnName("IDPHIEN");
            entity.Property(e => e.Giobatdau)
                .HasColumnType("datetime")
                .HasColumnName("GIOBATDAU");
            entity.Property(e => e.Gioketthuc)
                .HasColumnType("datetime")
                .HasColumnName("GIOKETTHUC");
            entity.Property(e => e.Idban)
                .HasMaxLength(50)
                .HasColumnName("IDBAN");

            entity.HasOne(d => d.IdbanNavigation).WithMany(p => p.Phienchois)
                .HasForeignKey(d => d.Idban)
                .HasConstraintName("FK__PHIENCHOI__IDBAN__656C112C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
