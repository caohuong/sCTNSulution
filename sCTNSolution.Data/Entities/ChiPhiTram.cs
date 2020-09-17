using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class ChiPhiTram
    {
        public ChiPhiTram()
        {
            ChiPhiTramChiTiet = new HashSet<ChiPhiTramChiTiet>();
        }

        public int RowId { get; set; }
        public string MaTram { get; set; }
        public DateTime ThangNam { get; set; }
        public int? Chastise { get; set; }
        public int? Money { get; set; }
        public int? Total { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<ChiPhiTramChiTiet> ChiPhiTramChiTiet { get; set; }
    }
}
