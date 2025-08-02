using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectFinal.Models;

public partial class DuAnWebContext : DbContext
{
    public DuAnWebContext()
    {
    }

    public DuAnWebContext(DbContextOptions<DuAnWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Phone> Phone { get; set; }
    public virtual DbSet<SanPham> SanPham { get; set; }
    public virtual DbSet<LapTop> LapTop { get; set; }
    public virtual DbSet<LapTopAll> LapTopAll { get; set; }
    public virtual DbSet<PhuKien> PhuKien { get; set; }
    public virtual DbSet<PC> PC { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<MoTaAcer> MoTaAcer { get; set; }
    public virtual DbSet<AnhAcerAP7> AnhAcerAP7 { get; set; }
    public virtual DbSet<MoTaIp> MoTaIp { get; set; }
    public virtual DbSet<AnhIp> AnhIp { get; set; }
    public virtual DbSet<Cart> Cart { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DuAnWeb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PC>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_PC");

            entity.ToTable("PC");

            entity.HasIndex(e => e.ID, "IDX_PC_ID");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.TenSp).HasMaxLength(200);
            entity.Property(e => e.GiaSp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LinkAnh).HasMaxLength(200);
            entity.Property(e => e.CauHinh1).HasMaxLength(200);
            entity.Property(e => e.CauHinh2).HasMaxLength(200);
        });
        modelBuilder.Entity<LapTop>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_LapTop");

            entity.ToTable("LapTop");

            entity.HasIndex(e => e.ID, "IDX_LapTop_ID");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.TenSp).HasMaxLength(200);
            entity.Property(e => e.GiaSp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LinkAnh).HasMaxLength(200);
            entity.Property(e => e.CauHinh1).HasMaxLength(200);
            entity.Property(e => e.CauHinh2).HasMaxLength(200);
        });
        modelBuilder.Entity<LapTopAll>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_LapTopAll");

            entity.ToTable("LapTopAll");

            entity.HasIndex(e => e.ID, "IDX_LapTopAll_ID");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.TenSp).HasMaxLength(200);
            entity.Property(e => e.GiaSp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LinkAnh).HasMaxLength(200);
            entity.Property(e => e.CauHinh1).HasMaxLength(200);
            entity.Property(e => e.CauHinh2).HasMaxLength(200);
        });
        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_Phone");

            entity.ToTable("Phone");

            entity.HasIndex(e => e.ID, "IDX_Phone_ID");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.TenSp).HasMaxLength(200);
            entity.Property(e => e.GiaSp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LinkAnh).HasMaxLength(200);
            entity.Property(e => e.CauHinh1).HasMaxLength(200);
            entity.Property(e => e.CauHinh2).HasMaxLength(200);
        });
        modelBuilder.Entity<PhuKien>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_PhuKien");

            entity.ToTable("PhuKien");

            entity.HasIndex(e => e.ID, "IDX_PhuKien_ID");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.TenSp).HasMaxLength(200);
            entity.Property(e => e.GiaSp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LinkAnh).HasMaxLength(200);
            entity.Property(e => e.CauHinh1).HasMaxLength(200);
            entity.Property(e => e.CauHinh2).HasMaxLength(200);
        });
        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__SanPham__3214EC278C57E736");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.ID, "IDX_SanPham_ID");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.TenSp).HasMaxLength(200);
            entity.Property(e => e.GiaSp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LinkAnh).HasMaxLength(200);
            entity.Property(e => e.CauHinh1).HasMaxLength(200);
            entity.Property(e => e.CauHinh2).HasMaxLength(200);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Users__F3DBC57364F99161");

            entity.HasIndex(e => e.Username, "IDX_User_Username");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .HasMaxLength(256)
                .HasColumnName("password");
        });

        modelBuilder.Entity<MoTaAcer>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_MoTaAcer");
            entity.ToTable("MoTaAcer");
            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.CardDoHoa)
                  .HasMaxLength(200)
                  .IsUnicode(true);
            entity.Property(e => e.ManHinh)
                  .HasMaxLength(300)
                  .IsUnicode(true);
            entity.Property(e => e.Chip)
                  .HasMaxLength(100)
                  .IsUnicode(true);
            entity.Property(e => e.RAM)
                  .HasMaxLength(100)
                  .IsUnicode(true);
            entity.Property(e => e.ROM)
                  .HasMaxLength(100)
                  .IsUnicode(true);
        });

        modelBuilder.Entity<MoTaIp>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_MoTaIp");
            entity.ToTable("MoTaIp");
            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Camera)
                  .HasMaxLength(200)
                  .IsUnicode(true);
            entity.Property(e => e.ManHinh)
                  .HasMaxLength(300)
                  .IsUnicode(true);
            entity.Property(e => e.Chip)
                  .HasMaxLength(100)
                  .IsUnicode(true);
            entity.Property(e => e.RAM)
                  .HasMaxLength(100)
                  .IsUnicode(true);
            entity.Property(e => e.ROM)
                  .HasMaxLength(100)
                  .IsUnicode(true);
        });
        modelBuilder.Entity<AnhAcerAP7>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_AnhAcerAP7");

            entity.ToTable("AnhAcerAP7");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Anh1)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh2)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh3)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh4)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh5)
                  .HasMaxLength(300)
                  .IsUnicode(false);

        });
        modelBuilder.Entity<AnhIp>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_AnhIp");

            entity.ToTable("AnhIp");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Anh1)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh2)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh3)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh4)
                  .HasMaxLength(300)
                  .IsUnicode(false);
            entity.Property(e => e.Anh5)
                  .HasMaxLength(300)
                  .IsUnicode(false);
        });
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.ToTable("Cart");
            entity.HasKey(e => e.ID);

            entity.Property(e => e.ID)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TenSp)
                .HasColumnName("TenSp")
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.GiaSp)
                .HasColumnName("GiaSp")
                .HasColumnType("decimal(18, 0)");

            entity.Property(e => e.LinkAnh)
                .HasColumnName("LinkAnh")
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.SoLuong)
                .HasColumnName("SoLuong")
                .HasDefaultValue(1); // ✅ đặt mặc định là 1 nếu cần
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
