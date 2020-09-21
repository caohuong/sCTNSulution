using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using sCTNSolution.Data.Entities;

namespace sCTNSolution.Data.EF
{
    public partial class CTNKGContext : DbContext
    {
        public CTNKGContext()
        {
        }

        public CTNKGContext(DbContextOptions<CTNKGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BangGiaNuoc> BangGiaNuoc { get; set; }
        public virtual DbSet<BangGiaNuocTheoTram> BangGiaNuocTheoTram { get; set; }
        public virtual DbSet<ChiPhiTram> ChiPhiTram { get; set; }
        public virtual DbSet<ChiPhiTramChiTiet> ChiPhiTramChiTiet { get; set; }
        public virtual DbSet<ChiSoTramNuoc> ChiSoTramNuoc { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<ClorinePhenDau> ClorinePhenDau { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CongNoKhachHang> CongNoKhachHang { get; set; }
        public virtual DbSet<DanhMucCum> DanhMucCum { get; set; }
        public virtual DbSet<DinhMucSuDung> DinhMucSuDung { get; set; }
        public virtual DbSet<DoanhThuTram> DoanhThuTram { get; set; }
        public virtual DbSet<DonViTinh> DonViTinh { get; set; }
        public virtual DbSet<DongHoKhongHoatDong> DongHoKhongHoatDong { get; set; }
        public virtual DbSet<GhiNhanThayDoiGiaVatTu> GhiNhanThayDoiGiaVatTu { get; set; }
        public virtual DbSet<GiaVatTu> GiaVatTu { get; set; }
        public virtual DbSet<GroupFunction> GroupFunction { get; set; }
        public virtual DbSet<GroupUser> GroupUser { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HopDongSuDung> HopDongSuDung { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KyXuatHoaDon> KyXuatHoaDon { get; set; }
        public virtual DbSet<LoaiChiPhi> LoaiChiPhi { get; set; }
        public virtual DbSet<LoaiVatTu> LoaiVatTu { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MainFunction> MainFunction { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhanVienVanHanhTram> NhanVienVanHanhTram { get; set; }
        public virtual DbSet<NhatKyBaoDuong> NhatKyBaoDuong { get; set; }
        public virtual DbSet<QuanHuyen> QuanHuyen { get; set; }
        public virtual DbSet<TaiSan> TaiSan { get; set; }
        public virtual DbSet<TaiSanTram> TaiSanTram { get; set; }
        public virtual DbSet<TinhThanh> TinhThanh { get; set; }
        public virtual DbSet<TramNuoc> TramNuoc { get; set; }
        public virtual DbSet<Tuyen> Tuyen { get; set; }
        public virtual DbSet<VatTu> VatTu { get; set; }
        public virtual DbSet<VatTuCongTy> VatTuCongTy { get; set; }
        public virtual DbSet<VatTuKhachHang> VatTuKhachHang { get; set; }
        public virtual DbSet<View3> View3 { get; set; }
        public virtual DbSet<ViewHopDongLaoDong> ViewHopDongLaoDong { get; set; }
        public virtual DbSet<XaPhuong> XaPhuong { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
////            if (!optionsBuilder.IsConfigured)
////            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
////                optionsBuilder.UseSqlServer("Server=PCDC1;Database=CTNKG;Trusted_Connection=True;");
////            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            modelBuilder.Entity<BangGiaNuoc>(entity =>
            {
                entity.HasKey(e => e.MaBangGia)
                    .HasName("PK_BangGiaNuoc_1");

                entity.Property(e => e.MaBangGia)
                    .HasColumnName("Ma_Bang_Gia")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.GiaCoDinh).HasColumnName("Gia_Co_Dinh");

                entity.Property(e => e.NgayBatDau)
                    .HasColumnName("Ngay_Bat_Dau")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnName("Ngay_Ket_Thuc")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguonNuoc).HasColumnName("Nguon_Nuoc");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<BangGiaNuocTheoTram>(entity =>
            {
                entity.HasKey(e => new { e.MaTram, e.MaBangGia, e.NgayApDung })
                    .HasName("PK_BangGiaNuocTheoTram_1");

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.MaBangGia)
                    .HasColumnName("Ma_Bang_Gia")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayApDung)
                    .HasColumnName("Ngay_Ap_Dung")
                    .HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.HeSo).HasColumnName("He_So");

                entity.Property(e => e.MucGia).HasColumnName("Muc_Gia");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnName("Ngay_Ket_Thuc")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.MaBangGiaNavigation)
                    .WithMany(p => p.BangGiaNuocTheoTram)
                    .HasForeignKey(d => d.MaBangGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BangGiaNuocTheoTram_BangGiaNuoc");
            });

            modelBuilder.Entity<ChiPhiTram>(entity =>
            {
                entity.HasKey(e => new { e.MaTram, e.ThangNam })
                    .HasName("PK_ChiPhiTram_1");

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.ThangNam)
                    .HasColumnName("Thang_Nam")
                    .HasColumnType("datetime");

                entity.Property(e => e.Chastise).HasComment("Phạt");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ChiPhiTramChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaTram, e.ThangNam, e.MaLoaiChiPhi });

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.ThangNam)
                    .HasColumnName("Thang_Nam")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaLoaiChiPhi)
                    .HasColumnName("Ma_Loai_Chi_Phi")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NgayGhiNhan)
                    .HasColumnName("Ngay_Ghi_Nhan")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.MaLoaiChiPhiNavigation)
                    .WithMany(p => p.ChiPhiTramChiTiet)
                    .HasForeignKey(d => d.MaLoaiChiPhi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiPhiTramChiTiet_LoaiChiPhi");

                entity.HasOne(d => d.ChiPhiTram)
                    .WithMany(p => p.ChiPhiTramChiTiet)
                    .HasForeignKey(d => new { d.MaTram, d.ThangNam })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiPhiTramChiTiet_ChiPhiTram");
            });

            modelBuilder.Entity<ChiSoTramNuoc>(entity =>
            {
                entity.HasKey(e => new { e.MaTram, e.ThangNam });

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.ThangNam)
                    .HasColumnName("Thang_Nam")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChenhLech).HasColumnName("Chenh_Lech");

                entity.Property(e => e.ChiPhiKhac).HasColumnName("Chi_Phi_Khac");

                entity.Property(e => e.ChiPhiMoiM3Nuoc).HasColumnName("Chi_Phi_Moi_M3_Nuoc");

                entity.Property(e => e.ChiPhiVanHanh).HasColumnName("Chi_Phi_Van_Hanh");

                entity.Property(e => e.ConLaiDuocLinh).HasColumnName("Con_Lai_Duoc_Linh");

                entity.Property(e => e.CongTacPhi).HasColumnName("Cong_Tac_Phi");

                entity.Property(e => e.DhdKyNay).HasColumnName("DHD_Ky_Nay");

                entity.Property(e => e.DhdKyTruoc).HasColumnName("DHD_Ky_Truoc");

                entity.Property(e => e.DhdSuDung).HasColumnName("DHD_Su_Dung");

                entity.Property(e => e.DhtKyNay).HasColumnName("DHT_Ky_Nay");

                entity.Property(e => e.DhtKyTruoc).HasColumnName("DHT_Ky_Truoc");

                entity.Property(e => e.DhtSuDung).HasColumnName("DHT_Su_Dung");

                entity.Property(e => e.DienThoai).HasColumnName("Dien_Thoai");

                entity.Property(e => e.DinhMuc).HasColumnName("Dinh_Muc");

                entity.Property(e => e.DoanhThuKyNay).HasColumnName("Doanh_Thu_Ky_Nay");

                entity.Property(e => e.DoanhThuKyTruoc).HasColumnName("Doanh_Thu_Ky_Truoc");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.GiaNuocBanRaBqChiPhi).HasColumnName("Gia_Nuoc_Ban_Ra_BQ_Chi_Phi");

                entity.Property(e => e.LuongNuocSxBqHo).HasColumnName("Luong_Nuoc_SX_BQ_Ho");

                entity.Property(e => e.LuongNuocTtBqHo).HasColumnName("Luong_Nuoc_TT_BQ_Ho");

                entity.Property(e => e.LuongTieuThu).HasColumnName("Luong_Tieu_Thu");

                entity.Property(e => e.NoCaNhan).HasColumnName("No_Ca_Nhan");

                entity.Property(e => e.NoCu).HasColumnName("No_Cu");

                entity.Property(e => e.NoKhachHang).HasColumnName("No_Khach_Hang");

                entity.Property(e => e.NoKyTruoc).HasColumnName("No_Ky_Truoc");

                entity.Property(e => e.NopDu).HasColumnName("Nop_Du");

                entity.Property(e => e.PhanNan).HasColumnName("Phan_Nan");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoGioLamViec).HasColumnName("So_Gio_Lam_Viec");

                entity.Property(e => e.SoHoHoatDong).HasColumnName("So_Ho_Hoat_Dong");

                entity.Property(e => e.SoHoaDon).HasColumnName("So_Hoa_Don");

                entity.Property(e => e.SoTienDaNop).HasColumnName("So_Tien_Da_Nop");

                entity.Property(e => e.SuaChua).HasColumnName("Sua_Chua");

                entity.Property(e => e.ThatThoat).HasColumnName("That_Thoat");

                entity.Property(e => e.ThatThoatDuoi22).HasColumnName("That_Thoat_Duoi22");

                entity.Property(e => e.ThucTe).HasColumnName("Thuc_Te");

                entity.Property(e => e.TienDien).HasColumnName("Tien_Dien");

                entity.Property(e => e.TinhTrang).HasColumnName("Tinh_Trang");

                entity.Property(e => e.TongChiPhi).HasColumnName("Tong_Chi_Phi");

                entity.Property(e => e.TongNo).HasColumnName("Tong_No");

                entity.Property(e => e.TongSoHo).HasColumnName("Tong_So_Ho");

                entity.Property(e => e.TyLeDienKhaiThac).HasColumnName("Ty_Le_Dien_Khai_Thac");

                entity.Property(e => e.TyLeDienTieuThu).HasColumnName("Ty_Le_Dien_Tieu_Thu");

                entity.Property(e => e.TyLeSuDungNuoc).HasColumnName("Ty_Le_Su_Dung_Nuoc");

                entity.Property(e => e.TyLeTtNuoc).HasColumnName("Ty_Le_TT_Nuoc");

                entity.Property(e => e.VanPhongPham).HasColumnName("Van_Phong_Pham");

                entity.HasOne(d => d.MaTramNavigation)
                    .WithMany(p => p.ChiSoTramNuoc)
                    .HasForeignKey(d => d.MaTram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiSoTramNuoc_TramNuoc");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu);

                entity.Property(e => e.MaChucVu)
                    .HasColumnName("Ma_Chuc_Vu")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenChucVu)
                    .HasColumnName("Ten_Chuc_Vu")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ClorinePhenDau>(entity =>
            {
                entity.HasKey(e => e.MaCpd)
                    .HasName("PK_ClorinePhenDau_1");

                entity.Property(e => e.MaCpd)
                    .HasColumnName("Ma_CPD")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasColumnName("Ghi_Chu");

                entity.Property(e => e.MaTram)
                    .IsRequired()
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.MaTramNavigation)
                    .WithMany(p => p.ClorinePhenDau)
                    .HasForeignKey(d => d.MaTram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClorinePhenDau_TramNuoc");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("Address_2")
                    .HasMaxLength(250);

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("Name_2")
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("Phone_2")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CongNoKhachHang>(entity =>
            {
                entity.HasKey(e => new { e.KyTinh, e.MaKh })
                    .HasName("PK_CongNoKhachHang_1");

                entity.Property(e => e.KyTinh)
                    .HasColumnName("Ky_Tinh")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaKh)
                    .HasColumnName("Ma_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThanhToan)
                    .HasColumnName("Ngay_Thanh_Toan")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiQuyetToan)
                    .HasColumnName("Nguoi_Quyet_Toan")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoSeri)
                    .HasColumnName("So_Seri")
                    .HasMaxLength(50);

                entity.Property(e => e.SoTien).HasColumnName("So_Tien");

                entity.Property(e => e.TinhTrang).HasColumnName("Tinh_Trang");

                entity.HasOne(d => d.KyTinhNavigation)
                    .WithMany(p => p.CongNoKhachHang)
                    .HasForeignKey(d => d.KyTinh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CongNoKhachHang_KyXuatHoaDon");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.CongNoKhachHang)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CongNoKhachHang_KhachHang");
            });

            modelBuilder.Entity<DanhMucCum>(entity =>
            {
                entity.HasKey(e => e.MaCum);

                entity.Property(e => e.MaCum)
                    .HasColumnName("Ma_Cum")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenCum)
                    .HasColumnName("Ten_Cum")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DinhMucSuDung>(entity =>
            {
                entity.HasKey(e => new { e.MaBangGia, e.MaDinhMuc })
                    .HasName("PK_BangDinhMucSuDung");

                entity.Property(e => e.MaBangGia)
                    .HasColumnName("Ma_Bang_Gia")
                    .HasMaxLength(50);

                entity.Property(e => e.MaDinhMuc)
                    .HasColumnName("Ma_Dinh_Muc")
                    .HasMaxLength(50);

                entity.Property(e => e.DinhMuc).HasColumnName("Dinh_Muc");

                entity.Property(e => e.DonGia).HasColumnName("Don_Gia");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NgayBatDau)
                    .HasColumnName("Ngay_Bat_Dau")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnName("Ngay_Ket_Thuc")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenDinhMuc)
                    .HasColumnName("Ten_Dinh_Muc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DoanhThuTram>(entity =>
            {
                entity.HasKey(e => new { e.MaTram, e.ThangNam });

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.ThangNam)
                    .HasColumnName("Thang_Nam")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoanhThuDaCoThue)
                    .HasColumnName("Doanh_Thu_Da_Co_Thue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuKyTruoc)
                    .HasColumnName("Doanh_Thu_Ky_Truoc")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuTruocThue)
                    .HasColumnName("Doanh_Thu_Truoc_Thue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NoCaNhan)
                    .HasColumnName("No_Ca_Nhan")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NoKhachHang)
                    .HasColumnName("No_Khach_Hang")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoTienThuThuc)
                    .HasColumnName("So_Tien_Thu_Thuc")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TienThue)
                    .HasColumnName("Tien_Thue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TinhTrang).HasColumnName("Tinh_Trang");

                entity.Property(e => e.TongChiPhi)
                    .HasColumnName("Tong_Chi_Phi")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TongDoanhThu)
                    .HasColumnName("Tong_Doanh_Thu")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TongSoTienCanThu)
                    .HasColumnName("Tong_So_Tien_Can_Thu")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<DonViTinh>(entity =>
            {
                entity.HasKey(e => e.MaDvt)
                    .HasName("PK_Don_Vi_Tinh");

                entity.Property(e => e.MaDvt)
                    .HasColumnName("Ma_DVT")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenDvt)
                    .HasColumnName("Ten_DVT")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DongHoKhongHoatDong>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(50);

                entity.Property(e => e.MaNn).HasColumnName("Ma_NN");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenNn)
                    .HasColumnName("Ten_NN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GhiNhanThayDoiGiaVatTu>(entity =>
            {
                entity.HasKey(e => e.NgayApDung)
                    .HasName("PK_GhiNhanThayDoiGiaVatTu_1");

                entity.Property(e => e.NgayApDung)
                    .HasColumnName("Ngay_Ap_Dung")
                    .HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnName("Ngay_Ket_Thuc")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GiaVatTu>(entity =>
            {
                entity.HasKey(e => new { e.MaVt, e.NgayApDung });

                entity.Property(e => e.MaVt)
                    .HasColumnName("Ma_VT")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayApDung)
                    .HasColumnName("Ngay_Ap_Dung")
                    .HasColumnType("datetime");

                entity.Property(e => e.DonGia)
                    .HasColumnName("Don_Gia")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnName("Ngay_Ket_Thuc")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.MaVtNavigation)
                    .WithMany(p => p.GiaVatTu)
                    .HasForeignKey(d => d.MaVt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiaVatTu_VatTu");

                entity.HasOne(d => d.NgayApDungNavigation)
                    .WithMany(p => p.GiaVatTu)
                    .HasForeignKey(d => d.NgayApDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiaVatTu_GhiNhanThayDoiGiaVatTu");
            });

            modelBuilder.Entity<GroupFunction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Menu1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Menu2)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GroupUser>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK_HoaDon_1");

                entity.Property(e => e.MaHoaDon)
                    .HasColumnName("Ma_Hoa_Don")
                    .HasMaxLength(50);

                entity.Property(e => e.ChiSoCu).HasColumnName("Chi_So_Cu");

                entity.Property(e => e.ChiSoMoi).HasColumnName("Chi_So_Moi");

                entity.Property(e => e.DaThanhToan).HasColumnName("Da_Thanh_Toan");

                entity.Property(e => e.Dm10)
                    .HasColumnName("DM10")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Dm20)
                    .HasColumnName("DM20")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Dm30)
                    .HasColumnName("DM30")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Dm40)
                    .HasColumnName("DM40")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.DonGiaTdm).HasColumnName("Don_Gia_TDM");

                entity.Property(e => e.DonGiaVdm)
                    .HasColumnName("Don_Gia_VDM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.KyTinh)
                    .HasColumnName("Ky_Tinh")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaKh)
                    .HasColumnName("Ma_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayLap)
                    .HasColumnName("Ngay_Lap")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThu)
                    .HasColumnName("Ngay_Thu")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.NguyenNhan).HasColumnName("Nguyen_Nhan");

                entity.Property(e => e.NhanVienGhiNuoc)
                    .HasColumnName("Nhan_Vien_Ghi_Nuoc")
                    .HasMaxLength(50);

                entity.Property(e => e.NhanVienThuTien)
                    .HasColumnName("Nhan_Vien_Thu_Tien")
                    .HasMaxLength(50);

                entity.Property(e => e.NoKyTruoc).HasColumnName("No_Ky_Truoc");

                entity.Property(e => e.PhanLoaiNuocSd)
                    .HasColumnName("Phan_Loai_Nuoc_SD")
                    .HasMaxLength(10);

                entity.Property(e => e.PhiNuocThai).HasColumnName("Phi_Nuoc_Thai");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoM3)
                    .HasColumnName("So_M3")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TenKh)
                    .HasColumnName("Ten_KH")
                    .HasMaxLength(60);

                entity.Property(e => e.ThanhTien).HasColumnName("Thanh_Tien");

                entity.Property(e => e.TienBaoTri)
                    .HasColumnName("Tien_Bao_Tri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TienTdm).HasColumnName("Tien_TDM");

                entity.Property(e => e.TienThueBao)
                    .HasColumnName("Tien_Thue_Bao")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TienVdm)
                    .HasColumnName("Tien_VDM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TongTien).HasColumnName("Tong_Tien");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.HasOne(d => d.KyTinhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.KyTinh)
                    .HasConstraintName("FK_HoaDon_KyXuatHoaDon");
            });

            modelBuilder.Entity<HopDongSuDung>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd)
                    .HasColumnName("Ma_HD")
                    .HasMaxLength(50);

                entity.Property(e => e.ChiPhiNhanCong).HasColumnName("Chi_Phi_Nhan_Cong");

                entity.Property(e => e.ChiPhiVanChuyen).HasColumnName("Chi_Phi_Van_Chuyen");

                entity.Property(e => e.ChieuDaiOng).HasColumnName("Chieu_Dai_Ong");

                entity.Property(e => e.DanGop).HasColumnName("Dan_Gop");

                entity.Property(e => e.DanhBo)
                    .HasColumnName("Danh_Bo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DinhKemFile)
                    .HasColumnName("Dinh_Kem_FILE")
                    .HasMaxLength(250);

                entity.Property(e => e.DinhMuc).HasColumnName("Dinh_Muc");

                entity.Property(e => e.DuongKinh).HasColumnName("Duong_Kinh");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.HieuDongHo)
                    .HasColumnName("Hieu_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiDongHo)
                    .HasColumnName("Loai_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiOng)
                    .HasColumnName("Loai_Ong")
                    .HasMaxLength(50);

                entity.Property(e => e.LuongCanSuDungTrongThang)
                    .HasColumnName("Luong_Can_Su_Dung_Trong_Thang")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MaDongHo)
                    .HasColumnName("Ma_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.MaKh)
                    .HasColumnName("Ma_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayKy)
                    .HasColumnName("Ngay_Ky")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayLapDh)
                    .HasColumnName("Ngay_Lap_DH")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.NhaNuocHoTro).HasColumnName("Nha_Nuoc_Ho_Tro");

                entity.Property(e => e.PhanLoaiNuocSd)
                    .HasColumnName("Phan_Loai_Nuoc_SD")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoGioCungCapNgay)
                    .HasColumnName("So_Gio_Cung_Cap_Ngay")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SoHd).HasColumnName("So_HD");

                entity.Property(e => e.ThanhToan)
                    .HasColumnName("Thanh_Toan")
                    .HasMaxLength(50);

                entity.Property(e => e.ThoiGianBaoHanhDh)
                    .HasColumnName("Thoi_Gian_Bao_Hanh_DH")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HopDongSuDung)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_HopDongSuDung_KhachHang");

                entity.HasOne(d => d.PhanLoaiNuocSdNavigation)
                    .WithMany(p => p.HopDongSuDung)
                    .HasForeignKey(d => d.PhanLoaiNuocSd)
                    .HasConstraintName("FK_HopDongSuDung_BangGiaNuoc");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK_KhachHang_1");

                entity.Property(e => e.MaKh)
                    .HasColumnName("Ma_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.ApKh)
                    .HasColumnName("Ap_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(50);

                entity.Property(e => e.DienChinhSach)
                    .HasColumnName("Dien_Chinh_Sach")
                    .HasMaxLength(50);

                entity.Property(e => e.DienThoai)
                    .HasColumnName("Dien_Thoai")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.MaDh)
                    .HasColumnName("Ma_DH")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTuyen)
                    .HasColumnName("Ma_Tuyen")
                    .HasMaxLength(50);

                entity.Property(e => e.MstKh)
                    .HasColumnName("MST_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.Mstk)
                    .HasColumnName("MSTK")
                    .HasMaxLength(50);

                entity.Property(e => e.NganHang)
                    .HasColumnName("Ngan_Hang")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayCap)
                    .HasColumnName("Ngay_Cap")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgaySuDung)
                    .HasColumnName("Ngay_Su_Dung")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTamNgung)
                    .HasColumnName("Ngay_Tam_Ngung")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.NoiCap)
                    .HasColumnName("Noi_Cap")
                    .HasMaxLength(50);

                entity.Property(e => e.QuanHuyen)
                    .HasColumnName("Quan_Huyen")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoNha)
                    .HasColumnName("So_Nha")
                    .HasMaxLength(100);

                entity.Property(e => e.SoNhanKhau).HasColumnName("So_Nhan_Khau");

                entity.Property(e => e.TamNgungSd).HasColumnName("Tam_Ngung_SD");

                entity.Property(e => e.TenKh)
                    .HasColumnName("Ten_KH")
                    .HasMaxLength(60);

                entity.Property(e => e.TienLddh)
                    .HasColumnName("Tien_LDDH")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TinhThanh)
                    .HasColumnName("Tinh_Thanh")
                    .HasMaxLength(50);

                entity.Property(e => e.ToKh)
                    .HasColumnName("To_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.XaPhuong)
                    .HasColumnName("Xa_Phuong")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaTramNavigation)
                    .WithMany(p => p.KhachHang)
                    .HasForeignKey(d => d.MaTram)
                    .HasConstraintName("FK_KhachHang_TramNuoc");

                entity.HasOne(d => d.QuanHuyenNavigation)
                    .WithMany(p => p.KhachHang)
                    .HasForeignKey(d => d.QuanHuyen)
                    .HasConstraintName("FK_KhachHang_QuanHuyen");

                entity.HasOne(d => d.TinhThanhNavigation)
                    .WithMany(p => p.KhachHang)
                    .HasForeignKey(d => d.TinhThanh)
                    .HasConstraintName("FK_KhachHang_TinhThanh");

                entity.HasOne(d => d.XaPhuongNavigation)
                    .WithMany(p => p.KhachHang)
                    .HasForeignKey(d => d.XaPhuong)
                    .HasConstraintName("FK_KhachHang_XaPhuong");
            });

            modelBuilder.Entity<KyXuatHoaDon>(entity =>
            {
                entity.HasKey(e => e.MaKyTinh)
                    .HasName("PK_KyTinh");

                entity.Property(e => e.MaKyTinh)
                    .HasColumnName("Ma_Ky_Tinh")
                    .HasColumnType("datetime");

                entity.Property(e => e.DenNgay)
                    .HasColumnName("Den_Ngay")
                    .HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TuNgay)
                    .HasColumnName("Tu_Ngay")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LoaiChiPhi>(entity =>
            {
                entity.HasKey(e => e.MaLoaiChiPhi);

                entity.Property(e => e.MaLoaiChiPhi)
                    .HasColumnName("Ma_Loai_Chi_Phi")
                    .HasMaxLength(50);

                entity.Property(e => e.ChiPhi)
                    .HasColumnName("Chi_Phi")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenLoaiChiPhi)
                    .HasColumnName("Ten_Loai_Chi_Phi")
                    .HasMaxLength(250);

                entity.Property(e => e.TinhTrang).HasColumnName("Tinh_Trang");
            });

            modelBuilder.Entity<LoaiVatTu>(entity =>
            {
                entity.HasKey(e => e.MaLoaiVt)
                    .HasName("PK_Loai_VT");

                entity.Property(e => e.MaLoaiVt)
                    .HasColumnName("Ma_Loai_VT")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenLoaiVt)
                    .HasColumnName("Ten_Loai_VT")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.GroupUser)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MainFunction>(entity =>
            {
                entity.HasKey(e => e.FormName);

                entity.Property(e => e.FormName).HasMaxLength(250);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Menu1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Menu2)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK_NhanVien_1");

                entity.Property(e => e.MaNv)
                    .HasColumnName("Ma_NV")
                    .HasMaxLength(50);

                entity.Property(e => e.ChucVu)
                    .HasColumnName("Chuc_Vu")
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChi)
                    .HasColumnName("Dia_Chi")
                    .HasMaxLength(250);

                entity.Property(e => e.DienThoai)
                    .HasColumnName("Dien_Thoai")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.NgaySinh)
                    .HasColumnName("Ngay_Sinh")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenNv)
                    .HasColumnName("Ten_NV")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<NhanVienVanHanhTram>(entity =>
            {
                entity.HasKey(e => new { e.MaNv, e.MaTram })
                    .HasName("PK_NhanVienVanHanhTram_1");

                entity.Property(e => e.MaNv)
                    .HasColumnName("Ma_NV")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.DienThoaiDd)
                    .HasColumnName("Dien_Thoai_DD")
                    .HasMaxLength(50);

                entity.Property(e => e.DienThoaiNhaRieng)
                    .HasColumnName("Dien_Thoai_Nha_Rieng")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NgayBatDau)
                    .HasColumnName("Ngay_Bat_Dau")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnName("Ngay_Ket_Thuc")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayKyHopDong)
                    .HasColumnName("Ngay_Ky_Hop_Dong")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TinhTrang).HasColumnName("Tinh_Trang");

                entity.Property(e => e.TrinhDoChuyenMon)
                    .HasColumnName("Trinh_Do_Chuyen_Mon")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.NhanVienVanHanhTram)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanVienVanHanhTram_NhanVien");

                entity.HasOne(d => d.MaTramNavigation)
                    .WithMany(p => p.NhanVienVanHanhTram)
                    .HasForeignKey(d => d.MaTram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanVienVanHanhTram_TramNuoc");
            });

            modelBuilder.Entity<NhatKyBaoDuong>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTram)
                    .IsRequired()
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayBaoTri)
                    .HasColumnName("Ngay_Bao_Tri")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoiDung)
                    .HasColumnName("Noi_Dung")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QuanHuyen>(entity =>
            {
                entity.HasKey(e => e.MaQuanHuyen);

                entity.Property(e => e.MaQuanHuyen)
                    .HasColumnName("Ma_Quan_Huyen")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.MaTinhThanh)
                    .HasColumnName("Ma_Tinh_Thanh")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenQuanHuyen)
                    .HasColumnName("Ten_Quan_Huyen")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TaiSan>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaTaiSan)
                    .IsRequired()
                    .HasColumnName("Ma_Tai_San")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TenTaiSan)
                    .HasColumnName("Ten_Tai_San")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TaiSanTram>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTaiSan)
                    .HasColumnName("Ma_Tai_San")
                    .HasMaxLength(10);

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.MoTa)
                    .HasColumnName("Mo_Ta")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoLuong).HasColumnName("So_Luong");
            });

            modelBuilder.Entity<TinhThanh>(entity =>
            {
                entity.HasKey(e => e.MaTinhThanh);

                entity.Property(e => e.MaTinhThanh)
                    .HasColumnName("Ma_Tinh_Thanh")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenTinhThanh)
                    .HasColumnName("Ten_Tinh_Thanh")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TramNuoc>(entity =>
            {
                entity.HasKey(e => e.MaTram)
                    .HasName("PK_TramNuoc_1");

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.CongSuat)
                    .HasColumnName("Cong_Suat")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.KichHoat).HasColumnName("Kich_Hoat");

                entity.Property(e => e.MaCum)
                    .HasColumnName("Ma_Cum")
                    .HasMaxLength(50);

                entity.Property(e => e.MaDongHo)
                    .HasColumnName("Ma_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayHoatDong)
                    .HasColumnName("Ngay_Hoat_Dong")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguonNuoc).HasColumnName("Nguon_Nuoc");

                entity.Property(e => e.QuanHuyen)
                    .HasColumnName("Quan_Huyen")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoHoDuKien).HasColumnName("So_Ho_Du_Kien");

                entity.Property(e => e.SoNha)
                    .HasColumnName("So_Nha")
                    .HasMaxLength(50);

                entity.Property(e => e.TenTram)
                    .IsRequired()
                    .HasColumnName("Ten_Tram")
                    .HasMaxLength(250);

                entity.Property(e => e.TheTichBe)
                    .HasColumnName("The_Tich_Be")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TinhThanh)
                    .HasColumnName("Tinh_Thanh")
                    .HasMaxLength(50);

                entity.Property(e => e.TongSoHo).HasColumnName("Tong_So_Ho");

                entity.Property(e => e.XaPhuong)
                    .HasColumnName("Xa_Phuong")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tuyen>(entity =>
            {
                entity.HasKey(e => new { e.MaTram, e.MaTuyen });

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTuyen)
                    .HasColumnName("Ma_Tuyen")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasColumnName("Ghi_Chu");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenTuyen)
                    .HasColumnName("Ten_Tuyen")
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<VatTu>(entity =>
            {
                entity.HasKey(e => e.MaVt);

                entity.Property(e => e.MaVt)
                    .HasColumnName("Ma_VT")
                    .HasMaxLength(50);

                entity.Property(e => e.DonViTinh)
                    .HasColumnName("Don_Vi_Tinh")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.LoaiVt)
                    .HasColumnName("Loai_VT")
                    .HasMaxLength(50);

                entity.Property(e => e.NhanHieu)
                    .HasColumnName("Nhan_Hieu")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenVatTu)
                    .HasColumnName("Ten_Vat_Tu")
                    .HasMaxLength(250);

                entity.HasOne(d => d.DonViTinhNavigation)
                    .WithMany(p => p.VatTu)
                    .HasForeignKey(d => d.DonViTinh)
                    .HasConstraintName("FK_VatTu_DonViTinh");

                entity.HasOne(d => d.LoaiVtNavigation)
                    .WithMany(p => p.VatTu)
                    .HasForeignKey(d => d.LoaiVt)
                    .HasConstraintName("FK_VatTu_LoaiVatTu");
            });

            modelBuilder.Entity<VatTuCongTy>(entity =>
            {
                entity.HasKey(e => new { e.MaVt, e.NgayNhap })
                    .HasName("PK_VatTuTram");

                entity.Property(e => e.MaVt)
                    .HasColumnName("Ma_VT")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayNhap)
                    .HasColumnName("Ngay_Nhap")
                    .HasColumnType("datetime");

                entity.Property(e => e.DonGiaNhap)
                    .HasColumnName("Don_Gia_Nhap")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.SoLuong)
                    .HasColumnName("So_Luong")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ThanhTienNhap)
                    .HasColumnName("Thanh_Tien_Nhap")
                    .HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.MaVtNavigation)
                    .WithMany(p => p.VatTuCongTy)
                    .HasForeignKey(d => d.MaVt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatTuTram_VatTu");
            });

            modelBuilder.Entity<VatTuKhachHang>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaVt })
                    .HasName("PK_VatTuKhachHang_1");

                entity.Property(e => e.MaHd)
                    .HasColumnName("Ma_HD")
                    .HasMaxLength(50);

                entity.Property(e => e.MaVt)
                    .HasColumnName("Ma_VT")
                    .HasMaxLength(50);

                entity.Property(e => e.DonGia)
                    .HasColumnName("Don_Gia")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayLap)
                    .HasColumnName("Ngay_Lap")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.SoLuong)
                    .HasColumnName("So_Luong")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ThanhTien)
                    .HasColumnName("Thanh_Tien")
                    .HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.VatTuKhachHang)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatTuKhachHang_HopDongSuDung");
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_3");

                entity.Property(e => e.ChiSoCu).HasColumnName("Chi_So_Cu");

                entity.Property(e => e.ChiSoMoi).HasColumnName("Chi_So_Moi");

                entity.Property(e => e.DaThanhToan).HasColumnName("Da_Thanh_Toan");

                entity.Property(e => e.DonGiaTdm)
                    .HasColumnName("Don_Gia_TDM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DonGiaVdm)
                    .HasColumnName("Don_Gia_VDM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.KyTinh)
                    .HasColumnName("Ky_Tinh")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaHoaDon)
                    .IsRequired()
                    .HasColumnName("Ma_Hoa_Don")
                    .HasMaxLength(50);

                entity.Property(e => e.MaKh)
                    .HasColumnName("Ma_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayLap)
                    .HasColumnName("Ngay_Lap")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThayDoi)
                    .HasColumnName("Ngay_Thay_Doi")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayThu)
                    .HasColumnName("Ngay_Thu")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThayDoi)
                    .HasColumnName("Nguoi_Thay_Doi")
                    .HasMaxLength(50);

                entity.Property(e => e.NguyenNhan).HasColumnName("Nguyen_Nhan");

                entity.Property(e => e.NhanVienGhiNuoc)
                    .HasColumnName("Nhan_Vien_Ghi_Nuoc")
                    .HasMaxLength(50);

                entity.Property(e => e.NhanVienThuTien)
                    .HasColumnName("Nhan_Vien_Thu_Tien")
                    .HasMaxLength(50);

                entity.Property(e => e.NoKyTruoc).HasColumnName("No_Ky_Truoc");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SoM3)
                    .HasColumnName("So_M3")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TenKh)
                    .HasColumnName("Ten_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.ThanhTien)
                    .HasColumnName("Thanh_Tien")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TienBaoTri)
                    .HasColumnName("Tien_Bao_Tri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TienTdm)
                    .HasColumnName("Tien_TDM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TienThueBao)
                    .HasColumnName("Tien_Thue_Bao")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TienVdm)
                    .HasColumnName("Tien_VDM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TongTien).HasColumnName("Tong_Tien");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ViewHopDongLaoDong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_HopDongLaoDong");

                entity.Property(e => e.HieuDongHo)
                    .HasColumnName("Hieu_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiDongHo)
                    .HasColumnName("Loai_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.MaDongHo)
                    .HasColumnName("Ma_Dong_Ho")
                    .HasMaxLength(50);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasColumnName("Ma_HD")
                    .HasMaxLength(50);

                entity.Property(e => e.MaKh)
                    .HasColumnName("Ma_KH")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayKy)
                    .HasColumnName("Ngay_Ky")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayLapDh)
                    .HasColumnName("Ngay_Lap_DH")
                    .HasColumnType("datetime");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TenKh)
                    .HasColumnName("Ten_KH")
                    .HasMaxLength(60);

                entity.Property(e => e.ThoiGianBaoHanhDh)
                    .HasColumnName("Thoi_Gian_Bao_Hanh_DH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<XaPhuong>(entity =>
            {
                entity.HasKey(e => e.MaXaPhuong);

                entity.Property(e => e.MaXaPhuong)
                    .HasColumnName("Ma_Xa_Phuong")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .HasColumnName("Ghi_Chu")
                    .HasMaxLength(250);

                entity.Property(e => e.MaQuanHuyen)
                    .HasColumnName("Ma_Quan_Huyen")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTinhThanh)
                    .HasColumnName("Ma_Tinh_Thanh")
                    .HasMaxLength(50);

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenXaPhuong)
                    .HasColumnName("Ten_Xa_Phuong")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("AppUsers");
                entity.Property(e => e.FirstName)
                    .HasColumnName("FirstName")
                    .HasMaxLength(200).IsRequired();

                entity.Property(e => e.LastName)
                    .HasColumnName("LastName")
                    .HasMaxLength(200).IsRequired();

                entity.Property(e => e.Dob)
                    .HasColumnName("Dob")
                    .HasColumnType("datetime").IsRequired();
            });

            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.ToTable("AppRoles");
                entity.Property(e => e.Description)
                    .HasColumnName("Description")
                    .HasMaxLength(200).IsRequired();
            });
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x=> new { x.UserId,x.RoleId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x=>x.UserId);

            //Create Seeding data
            var roleId = new Guid("C8AF3DFF-8F86-4423-8D8E-B058AD31BC9A");
            var adminId = new Guid("8082AD02-677A-46AE-954A-A223E8B8CF10");
            modelBuilder.Entity<AppRole>().HasData(new AppRole{ 
                Id = roleId,
                Name="admin",
                NormalizedName="admin",
                Description="Adminstrator role"
            });
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser {
                Id=adminId,
                UserName = "ctn.admin",
                NormalizedUserName = "admin",
                Email="s_h22002@yahoo.com",
                NormalizedEmail= "s_h22002@yahoo.com",
                EmailConfirmed=true,
                PasswordHash= hasher.HashPassword(null,"ctnkgadmin@123"),
                SecurityStamp=string.Empty,
                FirstName="Cao",
                LastName="Huong",
                Dob=new DateTime(1988,10,03)
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId=roleId,
                UserId=adminId
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
