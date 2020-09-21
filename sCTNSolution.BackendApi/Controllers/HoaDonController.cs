using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sCTNSolution.Application.Catalog.Hoadon;
using sCTNSolution.ViewModels.Catalog.Hoadon;
using sCTNSolution.ViewModels.Common;

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
        [HttpGet("bykytinh")]
        public async Task<IActionResult> Get([FromQuery] PagingRequestBase repuest)
        {
            var data = await _managerHoaDonService.GetAll(repuest);
            return Ok(data);
        }
        [HttpGet("bytram")]
        public async Task<IActionResult> Get([FromQuery] GetHoaDonPagingRepuest repuest)
        {
            var data = await _managerHoaDonService.GetAllByTram(repuest);
            return Ok(data);
        }
    }
}
