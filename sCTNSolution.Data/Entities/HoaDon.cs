using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class HoaDon
    {
        public int RowId { get; set; }
        public string MaHoaDon { get; set; }
        public DateTime? KyTinh { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public int? ChiSoCu { get; set; }
        public int? ChiSoMoi { get; set; }
        public decimal? SoM3 { get; set; }
        public double? DonGiaTdm { get; set; }
        public double? TienTdm { get; set; }
        public decimal? DonGiaVdm { get; set; }
        public decimal? TienVdm { get; set; }
        public decimal? TienBaoTri { get; set; }
        public decimal? TienThueBao { get; set; }
        public double? Vat { get; set; }
        public double? ThanhTien { get; set; }
        public double? NoKyTruoc { get; set; }
        public double? TongTien { get; set; }
        public DateTime? NgayLap { get; set; }
        public DateTime? NgayThu { get; set; }
        public bool? DaThanhToan { get; set; }
        public string NhanVienGhiNuoc { get; set; }
        public string NhanVienThuTien { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public int? NguyenNhan { get; set; }
        public double? PhiNuocThai { get; set; }
        public decimal? Dm10 { get; set; }
        public decimal? Dm20 { get; set; }
        public decimal? Dm30 { get; set; }
        public decimal? Dm40 { get; set; }
        public string PhanLoaiNuocSd { get; set; }

        public virtual KyXuatHoaDon KyTinhNavigation { get; set; }
    }
}
