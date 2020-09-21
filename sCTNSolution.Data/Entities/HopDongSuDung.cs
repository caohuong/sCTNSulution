using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class HopDongSuDung
    {
        public HopDongSuDung()
        {
            VatTuKhachHang = new HashSet<VatTuKhachHang>();
        }

        public int RowId { get; set; }
        public string MaHd { get; set; }
        public string MaKh { get; set; }
        public long? SoHd { get; set; }
        public string PhanLoaiNuocSd { get; set; }
        public DateTime? NgayKy { get; set; }
        public DateTime? NgayLapDh { get; set; }
        public string DinhKemFile { get; set; }
        public string DanhBo { get; set; }
        public string MaDongHo { get; set; }
        public string HieuDongHo { get; set; }
        public string LoaiDongHo { get; set; }
        public string ThoiGianBaoHanhDh { get; set; }
        public decimal? SoGioCungCapNgay { get; set; }
        public decimal? LuongCanSuDungTrongThang { get; set; }
        public int? DinhMuc { get; set; }
        public string LoaiOng { get; set; }
        public double? ChieuDaiOng { get; set; }
        public int? DuongKinh { get; set; }
        public int? ChiPhiNhanCong { get; set; }
        public int? ChiPhiVanChuyen { get; set; }
        public int? NhaNuocHoTro { get; set; }
        public int? DanGop { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string ThanhToan { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual BangGiaNuoc PhanLoaiNuocSdNavigation { get; set; }
        public virtual ICollection<VatTuKhachHang> VatTuKhachHang { get; set; }
    }
}
