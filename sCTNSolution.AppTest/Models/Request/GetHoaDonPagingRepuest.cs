using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Models.Request
{
    public class GetHoaDonPagingRepuest : PagingRequestBase
    {
        public string MaTram { get; set; }
    }
}
