using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class ViewHopDongLaoDong
    {
        public int RowId { get; set; }
        public string MaHd { get; set; }
        public string MaKh { get; set; }
        public DateTime? NgayKy { get; set; }
        public DateTime? NgayLapDh { get; set; }
        public string TenKh { get; set; }
        public string MaTram { get; set; }
        public string MaDongHo { get; set; }
        public string HieuDongHo { get; set; }
        public string LoaiDongHo { get; set; }
        public string ThoiGianBaoHanhDh { get; set; }
    }
}
