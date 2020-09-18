using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sCTNSolution.Application.Catalog.Hoadon;

namespace sCTNSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : ControllerBase
    {
        private readonly IManagerHoaDonService _managerHoaDonService;
        public HoaDonController(IManagerHoaDonService managerHoaDonService)
        {
            _managerHoaDonService = managerHoaDonService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _managerHoaDonService.GetAll();
            return Ok(data);
        }
    }
}
