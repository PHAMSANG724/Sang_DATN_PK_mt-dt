using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LKDT.Models
{
    public partial class LinhKienDienTuContext : DbContext
    {
        public LinhKienDienTuContext()
        {
        }

        public LinhKienDienTuContext(DbContextOptions<LinhKienDienTuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DiaChiGiaoHang> DiaChiGiaoHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TinTuc> TinTucs { get; set; }
        public virtual DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=TECHCARE\\SQLEXPRESS;Initial Catalog=LinhKienDienTu;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => e.MaCtdh);

                entity.ToTable("ChiTietDonHang");

                entity.Property(e => e.MaCtdh).HasColumnName("maCTDH");

                entity.Property(e => e.DonGia).HasColumnName("donGia");

                entity.Property(e => e.MaDh).HasColumnName("maDH");

                entity.Property(e => e.MaSp).HasColumnName("maSP");

                entity.Property(e => e.NgayMua)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayMua");

                entity.Property(e => e.SoLuong).HasColumnName("soLuong");

                entity.Property(e => e.TongTien).HasColumnName("tongTien");

                entity.HasOne(d => d.MaDhNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaDh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDonHang_DonHang");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDonHang_SanPham");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.MaDm);

                entity.ToTable("DanhMuc");

                entity.Property(e => e.MaDm).HasColumnName("maDM");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasColumnName("moTa");

                entity.Property(e => e.SapXep).HasColumnName("sapXep");

                entity.Property(e => e.TenDm)
                    .HasMaxLength(50)
                    .HasColumnName("tenDM");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(250)
                    .HasColumnName("tieuDe");

                entity.Property(e => e.TrangThai).HasColumnName("trangThai");

                entity.Property(e => e.Url)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<DiaChiGiaoHang>(entity =>
            {
                entity.HasKey(e => e.MaDcgh);

                entity.ToTable("DiaChiGiaoHang");

                entity.Property(e => e.MaDcgh).HasColumnName("maDCGH");

                entity.Property(e => e.DiaChi).HasColumnName("diaChi");

                entity.Property(e => e.MaKh).HasColumnName("maKH");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.MaDh);

                entity.ToTable("DonHang");

                entity.Property(e => e.MaDh).HasColumnName("maDH");

                entity.Property(e => e.DiaChi).HasColumnName("diaChi");

                entity.Property(e => e.DiachiGiaoHang).HasColumnName("diachiGiaoHang");

                entity.Property(e => e.GhiChu).HasColumnName("ghiChu");

                entity.Property(e => e.MaKh).HasColumnName("maKH");

                entity.Property(e => e.MaShipper).HasColumnName("maShipper");

                entity.Property(e => e.MaTrangThai).HasColumnName("maTrangThai");

                entity.Property(e => e.NgayGiao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayGiao");

                entity.Property(e => e.NgayMua)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayMua");

                entity.Property(e => e.NgayThanhToan)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayThanhToan");

                entity.Property(e => e.ThanhToan).HasColumnName("thanhToan");

                entity.Property(e => e.TongTien).HasColumnName("tongTien");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonHang_KhachHang");

                entity.HasOne(d => d.MaShipperNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaShipper)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonHang_Shippers");

                entity.HasOne(d => d.MaTrangThaiNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaTrangThai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonHang_TrangThaiDonHang");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh).HasColumnName("maKH");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChuoiMaHoa)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("chuoiMaHoa");

                entity.Property(e => e.DangNhapCuoi)
                    .HasColumnType("datetime")
                    .HasColumnName("dangNhapCuoi");

                entity.Property(e => e.DiaChi).HasColumnName("diaChi");

                entity.Property(e => e.DiachiKhac).HasColumnName("diachiKhac");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("hoTen");

                entity.Property(e => e.MaDcgh).HasColumnName("maDCGH");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTao");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TrangThai).HasColumnName("trangThai");

                entity.Property(e => e.Url)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.HasOne(d => d.MaDcghNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.MaDcgh)
                    .HasConstraintName("FK_KhachHang_DiaChiGiaoHang");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.HasKey(e => e.MaPage);

                entity.ToTable("Page");

                entity.Property(e => e.MaPage).HasColumnName("maPage");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MotaDai).HasColumnName("motaDai");

                entity.Property(e => e.MotaNgan)
                    .HasMaxLength(250)
                    .HasColumnName("motaNgan");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTao");

                entity.Property(e => e.SapXep).HasColumnName("sapXep");

                entity.Property(e => e.TenPage)
                    .HasMaxLength(250)
                    .HasColumnName("tenPage");

                entity.Property(e => e.TrangThai).HasColumnName("trangThai");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PhanQuyen>(entity =>
            {
                entity.HasKey(e => e.MaQuyen);

                entity.ToTable("PhanQuyen");

                entity.Property(e => e.MaQuyen).HasColumnName("maQuyen");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(50)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenQuyen)
                    .HasMaxLength(50)
                    .HasColumnName("tenQuyen");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp).HasColumnName("maSP");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DonGia).HasColumnName("donGia");

                entity.Property(e => e.MaDm).HasColumnName("maDM");

                entity.Property(e => e.MotaDai).HasColumnName("motaDai");

                entity.Property(e => e.MotaNgan)
                    .HasMaxLength(250)
                    .HasColumnName("motaNgan");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayChinhSua");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTao");

                entity.Property(e => e.TenSp)
                    .HasMaxLength(250)
                    .HasColumnName("tenSP");

                entity.Property(e => e.TrangThai).HasColumnName("trangThai");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("url");

                entity.HasOne(d => d.MaDmNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaDm)
                    .HasConstraintName("FK_SanPham_DanhMuc");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.HasKey(e => e.MaShipper);

                entity.Property(e => e.MaShipper).HasColumnName("maShipper");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(250)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenShipper)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tenShipper");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTk);

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaTk).HasColumnName("maTK");

                entity.Property(e => e.ChuoiMaHoa)
                    .IsUnicode(false)
                    .HasColumnName("chuoiMaHoa");

                entity.Property(e => e.DangnhapCuoi)
                    .HasColumnType("datetime")
                    .HasColumnName("dangnhapCuoi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .HasMaxLength(250)
                    .HasColumnName("hoTen");

                entity.Property(e => e.MaQuyen).HasColumnName("maQuyen");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("matKhau");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTao");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TrangThai).HasColumnName("trangThai");

                entity.HasOne(d => d.MaQuyenNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaQuyen)
                    .HasConstraintName("FK_TaiKhoan_PhanQuyen");
            });

            modelBuilder.Entity<TinTuc>(entity =>
            {
                entity.HasKey(e => e.MaTinTuc);

                entity.ToTable("TinTuc");

                entity.Property(e => e.MaTinTuc).HasColumnName("maTinTuc");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.LuotXem).HasColumnName("luotXem");

                entity.Property(e => e.MaDm).HasColumnName("maDM");

                entity.Property(e => e.MaTk).HasColumnName("maTK");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTao");

                entity.Property(e => e.NoiDung).HasColumnName("noiDung");

                entity.Property(e => e.TacGia)
                    .HasMaxLength(250)
                    .HasColumnName("tacGia");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(250)
                    .HasColumnName("tieuDe");

                entity.Property(e => e.TinHot).HasColumnName("tinHot");

                entity.Property(e => e.TrangThai).HasColumnName("trangThai");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("url");

                entity.HasOne(d => d.MaDmNavigation)
                    .WithMany(p => p.TinTucs)
                    .HasForeignKey(d => d.MaDm)
                    .HasConstraintName("FK_TinTuc_DanhMuc");

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany(p => p.TinTucs)
                    .HasForeignKey(d => d.MaTk)
                    .HasConstraintName("FK_TinTuc_TaiKhoan");
            });

            modelBuilder.Entity<TrangThaiDonHang>(entity =>
            {
                entity.HasKey(e => e.MaTrangThai);

                entity.ToTable("TrangThaiDonHang");

                entity.Property(e => e.MaTrangThai).HasColumnName("maTrangThai");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(250)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenTrangThai)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tenTrangThai");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
