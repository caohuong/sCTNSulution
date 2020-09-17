using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class KyXuatHoaDon
    {
        public KyXuatHoaDon()
        {
            CongNoKhachHang = new HashSet<CongNoKhachHang>();
            HoaDon = new HashSet<HoaDon>();
        }

        public int RowId { get; set; }
        public DateTime MaKyTinh { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<CongNoKhachHang> CongNoKhachHang { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
