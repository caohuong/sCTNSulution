using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class LoaiVatTu
    {
        public LoaiVatTu()
        {
            VatTu = new HashSet<VatTu>();
        }

        public int RowId { get; set; }
        public string MaLoaiVt { get; set; }
        public string TenLoaiVt { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<VatTu> VatTu { get; set; }
    }
}
