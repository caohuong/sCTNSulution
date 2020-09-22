using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Models.Result
{
    public class HoaDonByKyResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
        public DateTime KyHoaDon { get; set; }
    }
}
