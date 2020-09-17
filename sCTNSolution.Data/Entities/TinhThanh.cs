using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class TinhThanh
    {
        public TinhThanh()
        {
            KhachHang = new HashSet<KhachHang>();
        }

        public int RowId { get; set; }
        public string MaTinhThanh { get; set; }
        public string TenTinhThanh { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<KhachHang> KhachHang { get; set; }
    }
}
