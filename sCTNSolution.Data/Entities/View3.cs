using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class View3
    {
        public int RowId { get; set; }
        public string MaHoaDon { get; set; }
        public DateTime? KyTinh { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public int? ChiSoCu { get; set; }
        public int? ChiSoMoi { get; set; }
        public decimal? SoM3 { get; set; }
        public decimal? DonGiaTdm { get; set; }
        public decimal? TienTdm { get; set; }
        public decimal? DonGiaVdm { get; set; }
        public decimal? TienVdm { get; set; }
        public decimal? TienBaoTri { get; set; }
        public decimal? TienThueBao { get; set; }
        public decimal? Vat { get; set; }
        public decimal? ThanhTien { get; set; }
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
    }
}
