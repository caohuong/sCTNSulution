using sCTNSolution.AppTest.Models;
using sCTNSolution.AppTest.Models.Request;
using sCTNSolution.AppTest.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Service
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<List<TramNuocViewModel>> GetTram();
        Task<List<KyHoaDonResult>> GetKyHoaDon();
        Task<HoaDonByKyResult<HoaDonViewModel>> GetHoaDon(PagingRequestBase repuest);
        Task<HoaDonByKyResult<HoaDonViewModel>> GetHoaDon(GetHoaDonPagingRepuest repuest);

    }
}
