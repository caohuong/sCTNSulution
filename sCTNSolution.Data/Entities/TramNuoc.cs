using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class TramNuoc
    {
        public TramNuoc()
        {
            ChiSoTramNuoc = new HashSet<ChiSoTramNuoc>();
            ClorinePhenDau = new HashSet<ClorinePhenDau>();
            KhachHang = new HashSet<KhachHang>();
            NhanVienVanHanhTram = new HashSet<NhanVienVanHanhTram>();
        }

        public int RowId { get; set; }
        public string MaTram { get; set; }
        public string TenTram { get; set; }
        public string MaCum { get; set; }
        public string TinhThanh { get; set; }
        public string QuanHuyen { get; set; }
        public string XaPhuong { get; set; }
        public string SoNha { get; set; }
        public bool? KichHoat { get; set; }
        public DateTime? NgayHoatDong { get; set; }
        public decimal? CongSuat { get; set; }
        public decimal? TheTichBe { get; set; }
        public int? TongSoHo { get; set; }
        public int? SoHoDuKien { get; set; }
        public string MaDongHo { get; set; }
        public int? NguonNuoc { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<ChiSoTramNuoc> ChiSoTramNuoc { get; set; }
        public virtual ICollection<ClorinePhenDau> ClorinePhenDau { get; set; }
        public virtual ICollection<KhachHang> KhachHang { get; set; }
        public virtual ICollection<NhanVienVanHanhTram> NhanVienVanHanhTram { get; set; }
    }
}
