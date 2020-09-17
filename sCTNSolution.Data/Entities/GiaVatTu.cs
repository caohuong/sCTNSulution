using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class GiaVatTu
    {
        public int RowId { get; set; }
        public string MaVt { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public decimal? DonGia { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual VatTu MaVtNavigation { get; set; }
        public virtual GhiNhanThayDoiGiaVatTu NgayApDungNavigation { get; set; }
    }
}
