using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sCTNSolution.Application.Catalog.TramNuoc;

namespace sCTNSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TramNuocController : ControllerBase
    {
        private readonly IManageTramNuocService _managerTramNuocService;
        public TramNuocController(IManageTramNuocService managerTramNuocService)
        {
            _managerTramNuocService = managerTramNuocService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _managerTramNuocService.GetAll();
            return Ok(data);
        }
    }
}
