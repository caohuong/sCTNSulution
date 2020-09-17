using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class NhatKyBaoDuong
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public DateTime NgayBaoTri { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
    }
}
