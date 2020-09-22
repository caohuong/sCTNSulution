using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sCTNSolution.Application.Catalog.KyHoaDon;

namespace sCTNSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KyXuatHDController : ControllerBase
    {
        private readonly IKyHoaDonService  _kyHoaDonService;
        public KyXuatHDController(IKyHoaDonService kyHoaDonService)
        {
            _kyHoaDonService = kyHoaDonService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _kyHoaDonService.GetAll();
            return Ok(data);
        }
    }
}
