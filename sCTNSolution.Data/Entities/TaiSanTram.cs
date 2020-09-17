using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class TaiSanTram
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public string MaTaiSan { get; set; }
        public int? SoLuong { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
    }
}
