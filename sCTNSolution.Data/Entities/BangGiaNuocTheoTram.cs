using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class BangGiaNuocTheoTram
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public string MaBangGia { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? MucGia { get; set; }
        public double? HeSo { get; set; }
        public string GhiChu { get; set; }

        public virtual BangGiaNuoc MaBangGiaNavigation { get; set; }
    }
}
