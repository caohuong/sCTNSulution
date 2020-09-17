using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            CongNoKhachHang = new HashSet<CongNoKhachHang>();
            HopDongSuDung = new HashSet<HopDongSuDung>();
        }

        public int RowId { get; set; }
        public string MaTram { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public bool? GioiTinh { get; set; }
        public string NganHang { get; set; }
        public string Mstk { get; set; }
        public string MstKh { get; set; }
        public string Cmnd { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string SoNha { get; set; }
        public string ToKh { get; set; }
        public string ApKh { get; set; }
        public string XaPhuong { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string MaDh { get; set; }
        public decimal? TienLddh { get; set; }
        public int? SoNhanKhau { get; set; }
        public int? Nam { get; set; }
        public int? Nu { get; set; }
        public string DienChinhSach { get; set; }
        public DateTime? NgayTamNgung { get; set; }
        public bool? TamNgungSd { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgaySuDung { get; set; }
        public string MaTuyen { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual TramNuoc MaTramNavigation { get; set; }
        public virtual QuanHuyen QuanHuyenNavigation { get; set; }
        public virtual TinhThanh TinhThanhNavigation { get; set; }
        public virtual XaPhuong XaPhuongNavigation { get; set; }
        public virtual ICollection<CongNoKhachHang> CongNoKhachHang { get; set; }
        public virtual ICollection<HopDongSuDung> HopDongSuDung { get; set; }
    }
}
