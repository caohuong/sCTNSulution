using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Models
{
    public class TramNuocViewModel
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public string TenTram { get; set; }
        public string MaCum { get; set; }
        public string TinhThanh { get; set; }
        public string QuanHuyen { get; set; }
        public string XaPhuong { get; set; }
        public string SoNha { get; set; }
        public bool? KichHoat { get; set; }
        public DateTime? NgayHoatDong { get; set; }
        public decimal? CongSuat { get; set; }
        public decimal? TheTichBe { get; set; }
        public int? TongSoHo { get; set; }
        public int? SoHoDuKien { get; set; }
        public string MaDongHo { get; set; }
        public int? NguonNuoc { get; set; }
        public string GhiChu { get; set; }
    }
}
