using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class DoanhThuTram
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public DateTime ThangNam { get; set; }
        public decimal? TongDoanhThu { get; set; }
        public decimal? NoCaNhan { get; set; }
        public decimal? NoKhachHang { get; set; }
        public bool? TinhTrang { get; set; }
        public decimal? TongSoTienCanThu { get; set; }
        public decimal? SoTienThuThuc { get; set; }
        public decimal? TongChiPhi { get; set; }
        public decimal? DoanhThuTruocThue { get; set; }
        public decimal? TienThue { get; set; }
        public decimal? Vat { get; set; }
        public decimal? DoanhThuKyTruoc { get; set; }
        public decimal? DoanhThuDaCoThue { get; set; }
        public string GhiChu { get; set; }
    }
}
