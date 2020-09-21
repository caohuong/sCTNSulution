using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class DonViTinh
    {
        public DonViTinh()
        {
            VatTu = new HashSet<VatTu>();
        }

        public int RowId { get; set; }
        public string MaDvt { get; set; }
        public string TenDvt { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<VatTu> VatTu { get; set; }
    }
}
