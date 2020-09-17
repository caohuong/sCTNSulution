using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class NhanVienVanHanhTram
    {
        public int RowId { get; set; }
        public string MaNv { get; set; }
        public string MaTram { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool? TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public string DienThoaiDd { get; set; }
        public string DienThoaiNhaRieng { get; set; }
        public string TrinhDoChuyenMon { get; set; }
        public DateTime? NgayKyHopDong { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual TramNuoc MaTramNavigation { get; set; }
    }
}
