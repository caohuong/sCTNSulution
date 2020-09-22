using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Models.Result
{
    public class KyHoaDonResult
    {
        public int RowId { get; set; }
        public DateTime MaKyTinh { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string GhiChu { get; set; }
    }
}
