using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class XaPhuong
    {
        public XaPhuong()
        {
            KhachHang = new HashSet<KhachHang>();
        }

        public int RowId { get; set; }
        public string MaXaPhuong { get; set; }
        public string TenXaPhuong { get; set; }
        public string MaTinhThanh { get; set; }
        public string MaQuanHuyen { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<KhachHang> KhachHang { get; set; }
    }
}
