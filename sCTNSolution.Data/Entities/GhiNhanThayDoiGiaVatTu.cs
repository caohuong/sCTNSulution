using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class GhiNhanThayDoiGiaVatTu
    {
        public GhiNhanThayDoiGiaVatTu()
        {
            GiaVatTu = new HashSet<GiaVatTu>();
        }

        public int RowId { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual ICollection<GiaVatTu> GiaVatTu { get; set; }
    }
}
