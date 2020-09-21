using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class CongNoKhachHang
    {
        public int RowId { get; set; }
        public DateTime KyTinh { get; set; }
        public string MaKh { get; set; }
        public double? SoTien { get; set; }
        public bool? TinhTrang { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string SoSeri { get; set; }
        public string NguoiQuyetToan { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }

        public virtual KyXuatHoaDon KyTinhNavigation { get; set; }
        public virtual KhachHang MaKhNavigation { get; set; }
    }
}
