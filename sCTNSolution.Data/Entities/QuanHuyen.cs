using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class QuanHuyen
    {
        public QuanHuyen()
        {
            KhachHang = new HashSet<KhachHang>();
        }

        public int RowId { get; set; }
        public string MaQuanHuyen { get; set; }
        public string TenQuanHuyen { get; set; }
        public string MaTinhThanh { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<KhachHang> KhachHang { get; set; }
    }
}
