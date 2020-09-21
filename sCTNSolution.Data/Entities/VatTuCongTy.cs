using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class VatTuCongTy
    {
        public string MaVt { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal? SoLuong { get; set; }
        public decimal? DonGiaNhap { get; set; }
        public decimal? ThanhTienNhap { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual VatTu MaVtNavigation { get; set; }
    }
}
