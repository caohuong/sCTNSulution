
using sCTNSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace sCTNSolution.ViewModels.Catalog.Hoadon
{
    public class GetHoaDonPagingRepuest: PagingRequestBase
    {
        public string MaTram { get; set; }
    }
}
