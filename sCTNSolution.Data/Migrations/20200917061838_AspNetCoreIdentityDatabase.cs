using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sCTNSolution.Data.Migrations
{
    public partial class AspNetCoreIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    Dob = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BangGiaNuoc",
                columns: table => new
                {
                    Ma_Bang_Gia = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(maxLength: 250, nullable: true),
                    Gia_Co_Dinh = table.Column<double>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguon_Nuoc = table.Column<int>(nullable: true),
                    Ngay_Bat_Dau = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ngay_Ket_Thuc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGiaNuoc_1", x => x.Ma_Bang_Gia);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhiTram",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Thang_Nam = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chastise = table.Column<int>(nullable: true, comment: "Phạt"),
                    Money = table.Column<int>(nullable: true),
                    Total = table.Column<int>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhiTram_1", x => new { x.Ma_Tram, x.Thang_Nam });
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Ma_Chuc_Vu = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Chuc_Vu = table.Column<string>(maxLength: 100, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Ma_Chuc_Vu);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Name_2 = table.Column<string>(maxLength: 250, nullable: false),
                    Address = table.Column<string>(maxLength: 250, nullable: false),
                    Address_2 = table.Column<string>(maxLength: 250, nullable: false),
                    Phone = table.Column<string>(maxLength: 250, nullable: false),
                    Phone_2 = table.Column<string>(maxLength: 250, nullable: false),
                    Fax = table.Column<string>(maxLength: 250, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    Website = table.Column<string>(maxLength: 250, nullable: false),
                    TaxCode = table.Column<string>(maxLength: 50, nullable: false),
                    BankAccount = table.Column<string>(maxLength: 50, nullable: false),
                    BankName = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DanhMucCum",
                columns: table => new
                {
                    Ma_Cum = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Cum = table.Column<string>(maxLength: 250, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucCum", x => x.Ma_Cum);
                });

            migrationBuilder.CreateTable(
                name: "DinhMucSuDung",
                columns: table => new
                {
                    Ma_Bang_Gia = table.Column<string>(maxLength: 50, nullable: false),
                    Ma_Dinh_Muc = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Dinh_Muc = table.Column<string>(maxLength: 100, nullable: true),
                    Dinh_Muc = table.Column<int>(nullable: true),
                    Don_Gia = table.Column<double>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Ngay_Bat_Dau = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ngay_Ket_Thuc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDinhMucSuDung", x => new { x.Ma_Bang_Gia, x.Ma_Dinh_Muc });
                });

            migrationBuilder.CreateTable(
                name: "DoanhThuTram",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Thang_Nam = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tong_Doanh_Thu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    No_Ca_Nhan = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    No_Khach_Hang = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Tinh_Trang = table.Column<bool>(nullable: true),
                    Tong_So_Tien_Can_Thu = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    So_Tien_Thu_Thuc = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Tong_Chi_Phi = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Doanh_Thu_Truoc_Thue = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Tien_Thue = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    VAT = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Doanh_Thu_Ky_Truoc = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Doanh_Thu_Da_Co_Thue = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanhThuTram", x => new { x.Ma_Tram, x.Thang_Nam });
                });

            migrationBuilder.CreateTable(
                name: "DongHoKhongHoatDong",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_NN = table.Column<int>(nullable: false),
                    Ten_NN = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DonViTinh",
                columns: table => new
                {
                    Ma_DVT = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_DVT = table.Column<string>(maxLength: 250, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Don_Vi_Tinh", x => x.Ma_DVT);
                });

            migrationBuilder.CreateTable(
                name: "GhiNhanThayDoiGiaVatTu",
                columns: table => new
                {
                    Ngay_Ap_Dung = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay_Ket_Thuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhiNhanThayDoiGiaVatTu_1", x => x.Ngay_Ap_Dung);
                });

            migrationBuilder.CreateTable(
                name: "GroupFunction",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(maxLength: 250, nullable: false),
                    FormName = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    Module = table.Column<string>(maxLength: 250, nullable: false),
                    Menu1 = table.Column<string>(maxLength: 250, nullable: false),
                    Menu2 = table.Column<string>(maxLength: 250, nullable: false),
                    IsReadOnly = table.Column<int>(nullable: true),
                    SecurityButton = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GroupUser",
                columns: table => new
                {
                    No_ = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    GroupGrant = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "KyXuatHoaDon",
                columns: table => new
                {
                    Ma_Ky_Tinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tu_Ngay = table.Column<DateTime>(type: "datetime", nullable: true),
                    Den_Ngay = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyTinh", x => x.Ma_Ky_Tinh);
                });

            migrationBuilder.CreateTable(
                name: "LoaiChiPhi",
                columns: table => new
                {
                    Ma_Loai_Chi_Phi = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Loai_Chi_Phi = table.Column<string>(maxLength: 250, nullable: true),
                    Chi_Phi = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Tinh_Trang = table.Column<bool>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChiPhi", x => x.Ma_Loai_Chi_Phi);
                });

            migrationBuilder.CreateTable(
                name: "LoaiVatTu",
                columns: table => new
                {
                    Ma_Loai_VT = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Loai_VT = table.Column<string>(maxLength: 250, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai_VT", x => x.Ma_Loai_VT);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pass = table.Column<string>(maxLength: 250, nullable: false),
                    UserID = table.Column<string>(maxLength: 50, nullable: false),
                    GroupUser = table.Column<string>(maxLength: 250, nullable: false),
                    IsUsed = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "MainFunction",
                columns: table => new
                {
                    FormName = table.Column<string>(maxLength: 250, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    Module = table.Column<string>(maxLength: 250, nullable: false),
                    Menu1 = table.Column<string>(maxLength: 250, nullable: false),
                    Menu2 = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainFunction", x => x.FormName);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Ma_NV = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_NV = table.Column<string>(maxLength: 250, nullable: true),
                    Chuc_Vu = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Sinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gioi_Tinh = table.Column<bool>(nullable: true),
                    Dien_Thoai = table.Column<string>(maxLength: 50, nullable: true),
                    Dia_Chi = table.Column<string>(maxLength: 250, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien_1", x => x.Ma_NV);
                });

            migrationBuilder.CreateTable(
                name: "NhatKyBaoDuong",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Ngay_Bao_Tri = table.Column<DateTime>(type: "datetime", nullable: false),
                    Noi_Dung = table.Column<string>(maxLength: 250, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "QuanHuyen",
                columns: table => new
                {
                    Ma_Quan_Huyen = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Quan_Huyen = table.Column<string>(maxLength: 250, nullable: true),
                    Ma_Tinh_Thanh = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHuyen", x => x.Ma_Quan_Huyen);
                });

            migrationBuilder.CreateTable(
                name: "TaiSan",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false),
                    Ma_Tai_San = table.Column<string>(maxLength: 50, nullable: false),
                    Ten_Tai_San = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TaiSanTram",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: true),
                    Ma_Tai_San = table.Column<string>(maxLength: 10, nullable: true),
                    So_Luong = table.Column<int>(nullable: true),
                    Mo_Ta = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    Ma_Tinh_Thanh = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Tinh_Thanh = table.Column<string>(maxLength: 250, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanh", x => x.Ma_Tinh_Thanh);
                });

            migrationBuilder.CreateTable(
                name: "TramNuoc",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Tram = table.Column<string>(maxLength: 250, nullable: false),
                    Ma_Cum = table.Column<string>(maxLength: 50, nullable: true),
                    Tinh_Thanh = table.Column<string>(maxLength: 50, nullable: true),
                    Quan_Huyen = table.Column<string>(maxLength: 50, nullable: true),
                    Xa_Phuong = table.Column<string>(maxLength: 50, nullable: true),
                    So_Nha = table.Column<string>(maxLength: 50, nullable: true),
                    Kich_Hoat = table.Column<bool>(nullable: true),
                    Ngay_Hoat_Dong = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cong_Suat = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    The_Tich_Be = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Tong_So_Ho = table.Column<int>(nullable: true),
                    So_Ho_Du_Kien = table.Column<int>(nullable: true),
                    Ma_Dong_Ho = table.Column<string>(maxLength: 50, nullable: true),
                    Nguon_Nuoc = table.Column<int>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramNuoc_1", x => x.Ma_Tram);
                });

            migrationBuilder.CreateTable(
                name: "Tuyen",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Ma_Tuyen = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Tuyen = table.Column<string>(maxLength: 350, nullable: true),
                    Ghi_Chu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuyen", x => new { x.Ma_Tram, x.Ma_Tuyen });
                });

            migrationBuilder.CreateTable(
                name: "XaPhuong",
                columns: table => new
                {
                    Ma_Xa_Phuong = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Xa_Phuong = table.Column<string>(maxLength: 250, nullable: true),
                    Ma_Tinh_Thanh = table.Column<string>(maxLength: 50, nullable: true),
                    Ma_Quan_Huyen = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XaPhuong", x => x.Ma_Xa_Phuong);
                });

            migrationBuilder.CreateTable(
                name: "BangGiaNuocTheoTram",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Ma_Bang_Gia = table.Column<string>(maxLength: 50, nullable: false),
                    Ngay_Ap_Dung = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay_Ket_Thuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Muc_Gia = table.Column<int>(nullable: true),
                    He_So = table.Column<double>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGiaNuocTheoTram_1", x => new { x.Ma_Tram, x.Ma_Bang_Gia, x.Ngay_Ap_Dung });
                    table.ForeignKey(
                        name: "FK_BangGiaNuocTheoTram_BangGiaNuoc",
                        column: x => x.Ma_Bang_Gia,
                        principalTable: "BangGiaNuoc",
                        principalColumn: "Ma_Bang_Gia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Ma_Hoa_Don = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ky_Tinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ma_KH = table.Column<string>(maxLength: 50, nullable: true),
                    Ten_KH = table.Column<string>(maxLength: 60, nullable: true),
                    Chi_So_Cu = table.Column<int>(nullable: true),
                    Chi_So_Moi = table.Column<int>(nullable: true),
                    So_M3 = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Don_Gia_TDM = table.Column<double>(nullable: true),
                    Tien_TDM = table.Column<double>(nullable: true),
                    Don_Gia_VDM = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Tien_VDM = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Tien_Bao_Tri = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Tien_Thue_Bao = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    VAT = table.Column<double>(nullable: true),
                    Thanh_Tien = table.Column<double>(nullable: true),
                    No_Ky_Truoc = table.Column<double>(nullable: true),
                    Tong_Tien = table.Column<double>(nullable: true),
                    Ngay_Lap = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ngay_Thu = table.Column<DateTime>(type: "datetime", nullable: true),
                    Da_Thanh_Toan = table.Column<bool>(nullable: true),
                    Nhan_Vien_Ghi_Nuoc = table.Column<string>(maxLength: 50, nullable: true),
                    Nhan_Vien_Thu_Tien = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguyen_Nhan = table.Column<int>(nullable: true),
                    Phi_Nuoc_Thai = table.Column<double>(nullable: true),
                    DM10 = table.Column<decimal>(type: "numeric(5, 0)", nullable: true),
                    DM20 = table.Column<decimal>(type: "numeric(5, 0)", nullable: true),
                    DM30 = table.Column<decimal>(type: "numeric(5, 0)", nullable: true),
                    DM40 = table.Column<decimal>(type: "numeric(5, 0)", nullable: true),
                    Phan_Loai_Nuoc_SD = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon_1", x => x.Ma_Hoa_Don);
                    table.ForeignKey(
                        name: "FK_HoaDon_KyXuatHoaDon",
                        column: x => x.Ky_Tinh,
                        principalTable: "KyXuatHoaDon",
                        principalColumn: "Ma_Ky_Tinh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhiTramChiTiet",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Thang_Nam = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ma_Loai_Chi_Phi = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Ngay_Ghi_Nhan = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhiTramChiTiet", x => new { x.Ma_Tram, x.Thang_Nam, x.Ma_Loai_Chi_Phi });
                    table.ForeignKey(
                        name: "FK_ChiPhiTramChiTiet_LoaiChiPhi",
                        column: x => x.Ma_Loai_Chi_Phi,
                        principalTable: "LoaiChiPhi",
                        principalColumn: "Ma_Loai_Chi_Phi",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiPhiTramChiTiet_ChiPhiTram",
                        columns: x => new { x.Ma_Tram, x.Thang_Nam },
                        principalTable: "ChiPhiTram",
                        principalColumns: new[] { "Ma_Tram", "Thang_Nam" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VatTu",
                columns: table => new
                {
                    Ma_VT = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Vat_Tu = table.Column<string>(maxLength: 250, nullable: true),
                    Don_Vi_Tinh = table.Column<string>(maxLength: 50, nullable: true),
                    Loai_VT = table.Column<string>(maxLength: 50, nullable: true),
                    Nhan_Hieu = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTu", x => x.Ma_VT);
                    table.ForeignKey(
                        name: "FK_VatTu_DonViTinh",
                        column: x => x.Don_Vi_Tinh,
                        principalTable: "DonViTinh",
                        principalColumn: "Ma_DVT",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VatTu_LoaiVatTu",
                        column: x => x.Loai_VT,
                        principalTable: "LoaiVatTu",
                        principalColumn: "Ma_Loai_VT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiSoTramNuoc",
                columns: table => new
                {
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Thang_Nam = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tong_So_Ho = table.Column<int>(nullable: true),
                    So_Ho_Hoat_Dong = table.Column<int>(nullable: true),
                    Luong_Tieu_Thu = table.Column<int>(nullable: true),
                    Ty_Le_Su_Dung_Nuoc = table.Column<double>(nullable: true),
                    That_Thoat = table.Column<int>(nullable: true),
                    Chenh_Lech = table.Column<int>(nullable: true),
                    Ty_Le_TT_Nuoc = table.Column<double>(nullable: true),
                    DHT_Ky_Nay = table.Column<int>(nullable: true),
                    DHD_Ky_Nay = table.Column<int>(nullable: true),
                    DHT_Su_Dung = table.Column<int>(nullable: true),
                    DHD_Su_Dung = table.Column<int>(nullable: true),
                    DHT_Ky_Truoc = table.Column<int>(nullable: true),
                    DHD_Ky_Truoc = table.Column<int>(nullable: true),
                    Ty_Le_Dien_Khai_Thac = table.Column<double>(nullable: true),
                    Ty_Le_Dien_Tieu_Thu = table.Column<double>(nullable: true),
                    Luong_Nuoc_SX_BQ_Ho = table.Column<double>(nullable: true),
                    Luong_Nuoc_TT_BQ_Ho = table.Column<double>(nullable: true),
                    Dau = table.Column<double>(nullable: true),
                    Nhot = table.Column<double>(nullable: true),
                    Clorine = table.Column<double>(nullable: true),
                    Phen = table.Column<double>(nullable: true),
                    Chi_Phi_Van_Hanh = table.Column<int>(nullable: true),
                    Dinh_Muc = table.Column<int>(nullable: true),
                    Tien_Dien = table.Column<int>(nullable: true),
                    That_Thoat_Duoi22 = table.Column<int>(nullable: true),
                    Van_Phong_Pham = table.Column<int>(nullable: true),
                    Cong_Tac_Phi = table.Column<int>(nullable: true),
                    So_Hoa_Don = table.Column<int>(nullable: true),
                    Chi_Phi_Khac = table.Column<int>(nullable: true),
                    Tong_Chi_Phi = table.Column<int>(nullable: true),
                    Luong = table.Column<int>(nullable: true),
                    Phat = table.Column<int>(nullable: true),
                    Con_Lai_Duoc_Linh = table.Column<int>(nullable: true),
                    Dien_Thoai = table.Column<int>(nullable: true),
                    Sua_Chua = table.Column<int>(nullable: true),
                    Chi_Phi_Moi_M3_Nuoc = table.Column<int>(nullable: true),
                    So_Gio_Lam_Viec = table.Column<int>(nullable: true),
                    Phan_Nan = table.Column<double>(nullable: true),
                    Doanh_Thu_Ky_Truoc = table.Column<int>(nullable: true),
                    Doanh_Thu_Ky_Nay = table.Column<int>(nullable: true),
                    No_Ky_Truoc = table.Column<int>(nullable: true),
                    Xang = table.Column<int>(nullable: true),
                    So_Tien_Da_Nop = table.Column<int>(nullable: true),
                    Gia_Nuoc_Ban_Ra_BQ_Chi_Phi = table.Column<double>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    Nop_Du = table.Column<int>(nullable: true),
                    Thuc_Te = table.Column<int>(nullable: true),
                    No_Ca_Nhan = table.Column<int>(nullable: true),
                    No_Khach_Hang = table.Column<int>(nullable: true),
                    Tinh_Trang = table.Column<bool>(nullable: true),
                    No_Cu = table.Column<int>(nullable: true),
                    Tong_No = table.Column<int>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiSoTramNuoc", x => new { x.Ma_Tram, x.Thang_Nam });
                    table.ForeignKey(
                        name: "FK_ChiSoTramNuoc_TramNuoc",
                        column: x => x.Ma_Tram,
                        principalTable: "TramNuoc",
                        principalColumn: "Ma_Tram",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClorinePhenDau",
                columns: table => new
                {
                    Ma_CPD = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    Clorine = table.Column<double>(nullable: true),
                    Phen = table.Column<double>(nullable: true),
                    Dau = table.Column<double>(nullable: true),
                    Ghi_Chu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClorinePhenDau_1", x => x.Ma_CPD);
                    table.ForeignKey(
                        name: "FK_ClorinePhenDau_TramNuoc",
                        column: x => x.Ma_Tram,
                        principalTable: "TramNuoc",
                        principalColumn: "Ma_Tram",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienVanHanhTram",
                columns: table => new
                {
                    Ma_NV = table.Column<string>(maxLength: 50, nullable: false),
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay_Bat_Dau = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ngay_Ket_Thuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tinh_Trang = table.Column<bool>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Dien_Thoai_DD = table.Column<string>(maxLength: 50, nullable: true),
                    Dien_Thoai_Nha_Rieng = table.Column<string>(maxLength: 50, nullable: true),
                    Trinh_Do_Chuyen_Mon = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Ky_Hop_Dong = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienVanHanhTram_1", x => new { x.Ma_NV, x.Ma_Tram });
                    table.ForeignKey(
                        name: "FK_NhanVienVanHanhTram_NhanVien",
                        column: x => x.Ma_NV,
                        principalTable: "NhanVien",
                        principalColumn: "Ma_NV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVienVanHanhTram_TramNuoc",
                        column: x => x.Ma_Tram,
                        principalTable: "TramNuoc",
                        principalColumn: "Ma_Tram",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Ma_KH = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_Tram = table.Column<string>(maxLength: 50, nullable: true),
                    Ten_KH = table.Column<string>(maxLength: 60, nullable: true),
                    Gioi_Tinh = table.Column<bool>(nullable: true),
                    Ngan_Hang = table.Column<string>(maxLength: 50, nullable: true),
                    MSTK = table.Column<string>(maxLength: 50, nullable: true),
                    MST_KH = table.Column<string>(maxLength: 50, nullable: true),
                    CMND = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Cap = table.Column<DateTime>(type: "datetime", nullable: true),
                    Noi_Cap = table.Column<string>(maxLength: 50, nullable: true),
                    So_Nha = table.Column<string>(maxLength: 100, nullable: true),
                    To_KH = table.Column<string>(maxLength: 50, nullable: true),
                    Ap_KH = table.Column<string>(maxLength: 50, nullable: true),
                    Xa_Phuong = table.Column<string>(maxLength: 50, nullable: true),
                    Quan_Huyen = table.Column<string>(maxLength: 50, nullable: true),
                    Tinh_Thanh = table.Column<string>(maxLength: 50, nullable: true),
                    Dien_Thoai = table.Column<string>(maxLength: 50, nullable: true),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    Ma_DH = table.Column<string>(maxLength: 50, nullable: true),
                    Tien_LDDH = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    So_Nhan_Khau = table.Column<int>(nullable: true),
                    Nam = table.Column<int>(nullable: true),
                    Nu = table.Column<int>(nullable: true),
                    Dien_Chinh_Sach = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tam_Ngung = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tam_Ngung_SD = table.Column<bool>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Ngay_Su_Dung = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ma_Tuyen = table.Column<string>(maxLength: 50, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang_1", x => x.Ma_KH);
                    table.ForeignKey(
                        name: "FK_KhachHang_TramNuoc",
                        column: x => x.Ma_Tram,
                        principalTable: "TramNuoc",
                        principalColumn: "Ma_Tram",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KhachHang_QuanHuyen",
                        column: x => x.Quan_Huyen,
                        principalTable: "QuanHuyen",
                        principalColumn: "Ma_Quan_Huyen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KhachHang_TinhThanh",
                        column: x => x.Tinh_Thanh,
                        principalTable: "TinhThanh",
                        principalColumn: "Ma_Tinh_Thanh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KhachHang_XaPhuong",
                        column: x => x.Xa_Phuong,
                        principalTable: "XaPhuong",
                        principalColumn: "Ma_Xa_Phuong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiaVatTu",
                columns: table => new
                {
                    Ma_VT = table.Column<string>(maxLength: 50, nullable: false),
                    Ngay_Ap_Dung = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay_Ket_Thuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Don_Gia = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 50, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaVatTu", x => new { x.Ma_VT, x.Ngay_Ap_Dung });
                    table.ForeignKey(
                        name: "FK_GiaVatTu_VatTu",
                        column: x => x.Ma_VT,
                        principalTable: "VatTu",
                        principalColumn: "Ma_VT",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GiaVatTu_GhiNhanThayDoiGiaVatTu",
                        column: x => x.Ngay_Ap_Dung,
                        principalTable: "GhiNhanThayDoiGiaVatTu",
                        principalColumn: "Ngay_Ap_Dung",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VatTuCongTy",
                columns: table => new
                {
                    Ma_VT = table.Column<string>(maxLength: 50, nullable: false),
                    Ngay_Nhap = table.Column<DateTime>(type: "datetime", nullable: false),
                    So_Luong = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Don_Gia_Nhap = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Thanh_Tien_Nhap = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTuTram", x => new { x.Ma_VT, x.Ngay_Nhap });
                    table.ForeignKey(
                        name: "FK_VatTuTram_VatTu",
                        column: x => x.Ma_VT,
                        principalTable: "VatTu",
                        principalColumn: "Ma_VT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CongNoKhachHang",
                columns: table => new
                {
                    Ky_Tinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ma_KH = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    So_Tien = table.Column<double>(nullable: true),
                    Tinh_Trang = table.Column<bool>(nullable: true),
                    Ngay_Thanh_Toan = table.Column<DateTime>(type: "datetime", nullable: true),
                    So_Seri = table.Column<string>(maxLength: 50, nullable: true),
                    Nguoi_Quyet_Toan = table.Column<string>(maxLength: 50, nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongNoKhachHang_1", x => new { x.Ky_Tinh, x.Ma_KH });
                    table.ForeignKey(
                        name: "FK_CongNoKhachHang_KyXuatHoaDon",
                        column: x => x.Ky_Tinh,
                        principalTable: "KyXuatHoaDon",
                        principalColumn: "Ma_Ky_Tinh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongNoKhachHang_KhachHang",
                        column: x => x.Ma_KH,
                        principalTable: "KhachHang",
                        principalColumn: "Ma_KH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HopDongSuDung",
                columns: table => new
                {
                    Ma_HD = table.Column<string>(maxLength: 50, nullable: false),
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_KH = table.Column<string>(maxLength: 50, nullable: true),
                    So_HD = table.Column<long>(nullable: true),
                    Phan_Loai_Nuoc_SD = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Ky = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ngay_Lap_DH = table.Column<DateTime>(type: "datetime", nullable: true),
                    Dinh_Kem_FILE = table.Column<string>(maxLength: 250, nullable: true),
                    Danh_Bo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Ma_Dong_Ho = table.Column<string>(maxLength: 50, nullable: true),
                    Hieu_Dong_Ho = table.Column<string>(maxLength: 50, nullable: true),
                    Loai_Dong_Ho = table.Column<string>(maxLength: 50, nullable: true),
                    Thoi_Gian_Bao_Hanh_DH = table.Column<string>(maxLength: 50, nullable: true),
                    So_Gio_Cung_Cap_Ngay = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Luong_Can_Su_Dung_Trong_Thang = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Dinh_Muc = table.Column<int>(nullable: true),
                    Loai_Ong = table.Column<string>(maxLength: 50, nullable: true),
                    Chieu_Dai_Ong = table.Column<double>(nullable: true),
                    Duong_Kinh = table.Column<int>(nullable: true),
                    Chi_Phi_Nhan_Cong = table.Column<int>(nullable: true),
                    Chi_Phi_Van_Chuyen = table.Column<int>(nullable: true),
                    Nha_Nuoc_Ho_Tro = table.Column<int>(nullable: true),
                    Dan_Gop = table.Column<int>(nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 250, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Thanh_Toan = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDongSuDung", x => x.Ma_HD);
                    table.ForeignKey(
                        name: "FK_HopDongSuDung_KhachHang",
                        column: x => x.Ma_KH,
                        principalTable: "KhachHang",
                        principalColumn: "Ma_KH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HopDongSuDung_BangGiaNuoc",
                        column: x => x.Phan_Loai_Nuoc_SD,
                        principalTable: "BangGiaNuoc",
                        principalColumn: "Ma_Bang_Gia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VatTuKhachHang",
                columns: table => new
                {
                    Ma_HD = table.Column<string>(maxLength: 50, nullable: false),
                    Ma_VT = table.Column<string>(maxLength: 50, nullable: false),
                    Ngay_Lap = table.Column<DateTime>(type: "datetime", nullable: true),
                    So_Luong = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Don_Gia = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Thanh_Tien = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    Ghi_Chu = table.Column<string>(maxLength: 50, nullable: true),
                    Nguoi_Tao = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Tao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nguoi_Thay_Doi = table.Column<string>(maxLength: 50, nullable: true),
                    Ngay_Thay_Doi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTuKhachHang_1", x => new { x.Ma_HD, x.Ma_VT });
                    table.ForeignKey(
                        name: "FK_VatTuKhachHang_HopDongSuDung",
                        column: x => x.Ma_HD,
                        principalTable: "HopDongSuDung",
                        principalColumn: "Ma_HD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangGiaNuocTheoTram_Ma_Bang_Gia",
                table: "BangGiaNuocTheoTram",
                column: "Ma_Bang_Gia");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhiTramChiTiet_Ma_Loai_Chi_Phi",
                table: "ChiPhiTramChiTiet",
                column: "Ma_Loai_Chi_Phi");

            migrationBuilder.CreateIndex(
                name: "IX_ClorinePhenDau_Ma_Tram",
                table: "ClorinePhenDau",
                column: "Ma_Tram");

            migrationBuilder.CreateIndex(
                name: "IX_CongNoKhachHang_Ma_KH",
                table: "CongNoKhachHang",
                column: "Ma_KH");

            migrationBuilder.CreateIndex(
                name: "IX_GiaVatTu_Ngay_Ap_Dung",
                table: "GiaVatTu",
                column: "Ngay_Ap_Dung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_Ky_Tinh",
                table: "HoaDon",
                column: "Ky_Tinh");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongSuDung_Ma_KH",
                table: "HopDongSuDung",
                column: "Ma_KH");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongSuDung_Phan_Loai_Nuoc_SD",
                table: "HopDongSuDung",
                column: "Phan_Loai_Nuoc_SD");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Ma_Tram",
                table: "KhachHang",
                column: "Ma_Tram");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Quan_Huyen",
                table: "KhachHang",
                column: "Quan_Huyen");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Tinh_Thanh",
                table: "KhachHang",
                column: "Tinh_Thanh");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Xa_Phuong",
                table: "KhachHang",
                column: "Xa_Phuong");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienVanHanhTram_Ma_Tram",
                table: "NhanVienVanHanhTram",
                column: "Ma_Tram");

            migrationBuilder.CreateIndex(
                name: "IX_VatTu_Don_Vi_Tinh",
                table: "VatTu",
                column: "Don_Vi_Tinh");

            migrationBuilder.CreateIndex(
                name: "IX_VatTu_Loai_VT",
                table: "VatTu",
                column: "Loai_VT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "BangGiaNuocTheoTram");

            migrationBuilder.DropTable(
                name: "ChiPhiTramChiTiet");

            migrationBuilder.DropTable(
                name: "ChiSoTramNuoc");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "ClorinePhenDau");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "CongNoKhachHang");

            migrationBuilder.DropTable(
                name: "DanhMucCum");

            migrationBuilder.DropTable(
                name: "DinhMucSuDung");

            migrationBuilder.DropTable(
                name: "DoanhThuTram");

            migrationBuilder.DropTable(
                name: "DongHoKhongHoatDong");

            migrationBuilder.DropTable(
                name: "GiaVatTu");

            migrationBuilder.DropTable(
                name: "GroupFunction");

            migrationBuilder.DropTable(
                name: "GroupUser");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "MainFunction");

            migrationBuilder.DropTable(
                name: "NhanVienVanHanhTram");

            migrationBuilder.DropTable(
                name: "NhatKyBaoDuong");

            migrationBuilder.DropTable(
                name: "TaiSan");

            migrationBuilder.DropTable(
                name: "TaiSanTram");

            migrationBuilder.DropTable(
                name: "Tuyen");

            migrationBuilder.DropTable(
                name: "VatTuCongTy");

            migrationBuilder.DropTable(
                name: "VatTuKhachHang");

            migrationBuilder.DropTable(
                name: "LoaiChiPhi");

            migrationBuilder.DropTable(
                name: "ChiPhiTram");

            migrationBuilder.DropTable(
                name: "GhiNhanThayDoiGiaVatTu");

            migrationBuilder.DropTable(
                name: "KyXuatHoaDon");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "VatTu");

            migrationBuilder.DropTable(
                name: "HopDongSuDung");

            migrationBuilder.DropTable(
                name: "DonViTinh");

            migrationBuilder.DropTable(
                name: "LoaiVatTu");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "BangGiaNuoc");

            migrationBuilder.DropTable(
                name: "TramNuoc");

            migrationBuilder.DropTable(
                name: "QuanHuyen");

            migrationBuilder.DropTable(
                name: "TinhThanh");

            migrationBuilder.DropTable(
                name: "XaPhuong");
        }
    }
}
