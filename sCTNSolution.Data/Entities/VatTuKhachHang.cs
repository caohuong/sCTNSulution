using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class VatTuKhachHang
    {
        public string MaHd { get; set; }
        public string MaVt { get; set; }
        public DateTime? NgayLap { get; set; }
        public decimal? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual HopDongSuDung MaHdNavigation { get; set; }
    }
}
