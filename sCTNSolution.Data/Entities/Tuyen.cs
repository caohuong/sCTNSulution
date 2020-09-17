using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class Tuyen
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public string MaTuyen { get; set; }
        public string TenTuyen { get; set; }
        public string GhiChu { get; set; }
    }
}
