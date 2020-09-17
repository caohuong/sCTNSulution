using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class LoaiChiPhi
    {
        public LoaiChiPhi()
        {
            ChiPhiTramChiTiet = new HashSet<ChiPhiTramChiTiet>();
        }

        public int RowId { get; set; }
        public string MaLoaiChiPhi { get; set; }
        public string TenLoaiChiPhi { get; set; }
        public decimal? ChiPhi { get; set; }
        public bool? TinhTrang { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<ChiPhiTramChiTiet> ChiPhiTramChiTiet { get; set; }
    }
}
