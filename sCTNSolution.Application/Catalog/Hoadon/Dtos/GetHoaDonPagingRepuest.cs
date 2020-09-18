using sCTNSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace sCTNSolution.Application.Catalog.Hoadon.Dtos
{
    public class GetHoaDonPagingRepuest: PagingRequestBase
    {
        public string MaTram { get; set; }
    }
}
