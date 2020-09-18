using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sCTNSolution.Data.EF;
namespace sCTNSolution.Application.Catalog.TramNuoc
{
    public class ManageTramNuocService : IManageTramNuocService
    {
        private CTNKGContext _context;
        public ManageTramNuocService(CTNKGContext context)
        {
            _context = context;
        }
        public async Task<List<sCTNSolution.Data.Entities.TramNuoc>> GetAll()
        {
            var tramnuoc = await _context.TramNuoc.ToListAsync();
            return tramnuoc;
        }
    }
}
