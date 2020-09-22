using Newtonsoft.Json;
using sCTNSolution.AppTest.Models;
using sCTNSolution.AppTest.Models.Request;
using sCTNSolution.AppTest.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Service
{
    public class UserApiClient : IUserApiClient
    {
        
        public UserApiClient()
        {
           
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            string keyapi = "users/authenticate";
            var token = await serverapi.Authenticate<LoginRequest>(keyapi, request);
            if (!string.IsNullOrEmpty(token)) serverapi._token = token;
            return token;
        }

        public async Task<HoaDonByKyResult<HoaDonViewModel>> GetHoaDon(PagingRequestBase repuest)
        {
            string keyapi = $"hoadon/bykytinh?KyHoadon={repuest.KyHoadon}";
            return await serverapi.GetDataAsync<HoaDonByKyResult<HoaDonViewModel>>(keyapi);
        }

        public async Task<HoaDonByKyResult<HoaDonViewModel>> GetHoaDon(GetHoaDonPagingRepuest repuest)
        {
            string keyapi = $"HoaDon/bytram?KyHoadon={repuest.KyHoadon}&MaTram={repuest.MaTram}";
            return await serverapi.GetDataAsync<HoaDonByKyResult<HoaDonViewModel>>(keyapi);
        }

        public async Task<List<KyHoaDonResult>> GetKyHoaDon()
        {
            string keyapi = "KyXuatHD";
            return await serverapi.GetListDataAsync<KyHoaDonResult>(keyapi);
        }

        public async Task<List<TramNuocViewModel>> GetTram()
        {
            string keyapi = "TramNuoc";
            return await serverapi.GetListDataAsync<TramNuocViewModel>(keyapi);
        }
    }
}
