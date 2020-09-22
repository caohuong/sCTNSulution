using Microsoft.EntityFrameworkCore;
using sCTNSolution.Data.EF;
using sCTNSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.Application.Catalog.KyHoaDon
{
    public class KyHoaDonService : IKyHoaDonService
    {
        private CTNKGContext _context;
        public KyHoaDonService(CTNKGContext context)
        {
            _context = context;
        }
        public async Task<List<KyXuatHoaDon>> GetAll()
        {
            var kyhoadon = await _context.KyXuatHoaDon.ToListAsync();
            return kyhoadon;
        }
    }
}
