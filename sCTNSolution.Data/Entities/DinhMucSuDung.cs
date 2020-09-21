using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class DinhMucSuDung
    {
        public int RowId { get; set; }
        public string MaBangGia { get; set; }
        public string MaDinhMuc { get; set; }
        public string TenDinhMuc { get; set; }
        public int? DinhMuc { get; set; }
        public double? DonGia { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
