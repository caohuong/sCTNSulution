using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class ChiPhiTramChiTiet
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public DateTime ThangNam { get; set; }
        public string MaLoaiChiPhi { get; set; }
        public decimal? Total { get; set; }
        public DateTime? NgayGhiNhan { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual ChiPhiTram ChiPhiTram { get; set; }
        public virtual LoaiChiPhi MaLoaiChiPhiNavigation { get; set; }
    }
}
