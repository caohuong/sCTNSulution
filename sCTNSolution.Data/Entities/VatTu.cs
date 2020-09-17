using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class VatTu
    {
        public VatTu()
        {
            GiaVatTu = new HashSet<GiaVatTu>();
            VatTuCongTy = new HashSet<VatTuCongTy>();
        }

        public int RowId { get; set; }
        public string MaVt { get; set; }
        public string TenVatTu { get; set; }
        public string DonViTinh { get; set; }
        public string LoaiVt { get; set; }
        public string NhanHieu { get; set; }
        public string GhiChu { get; set; }

        public virtual DonViTinh DonViTinhNavigation { get; set; }
        public virtual LoaiVatTu LoaiVtNavigation { get; set; }
        public virtual ICollection<GiaVatTu> GiaVatTu { get; set; }
        public virtual ICollection<VatTuCongTy> VatTuCongTy { get; set; }
    }
}
