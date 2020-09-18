

using sCTNSolution.ViewModels.Catalog.Hoadon;
using sCTNSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.Application.Catalog.Hoadon
{
    public interface IManagerHoaDonService
    {
       // List<PagedHoaDonByKyViewModel<HoaDonViewModel>> GetAll();
        Task<PagedHoaDonByKyResult<HoaDonViewModel>> GetAll(PagingRequestBase repuest);
        Task<PagedHoaDonByKyResult<HoaDonViewModel>> GetAllByTram(GetHoaDonPagingRepuest repuest);
    }
}
