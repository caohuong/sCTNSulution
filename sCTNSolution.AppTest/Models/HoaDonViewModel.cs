using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Models
{
    public class HoaDonViewModel
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
        public Nullable<double> Don_Gia_DM10 { get; set; }
        public Nullable<double> Don_Gia_DM20 { get; set; }
        public Nullable<double> Don_Gia_DM30 { get; set; }
        public Nullable<double> Don_Gia_DM40 { get; set; }
        //public Nullable<System.DateTime> Ngayin { get; set; }
        //public string NgayInString { get; set; }
        //public string LanInString { get; set; }
        public double PhanTramPhiSH { get; set; }
        public string MSThue { get; set; }
        public string So_Nha { get; set; }
        public string To_KH { get; set; }
        public string Ap_KH { get; set; }
        public string Xa_Phuong { get; set; }
        public Nullable<DateTime> Ky_Tinh_TuNgay { get; set; }
        public Nullable<DateTime> Ky_Tinh_DenNgay { get; set; }

        public Nullable<double> TT_DM10 { get; set; }
        public Nullable<double> TT_DM20 { get; set; }
        public Nullable<double> TT_DM30 { get; set; }
        public Nullable<double> TT_DM40 { get; set; }
        public string BangChu { get; set; }
        public int PhanTram5 { get; set; }
        public double PhanTram10 { get; set; }
        public string DiaChi { get; set; }
        public string StringKy_Tinh { get; set; }
    }
}
