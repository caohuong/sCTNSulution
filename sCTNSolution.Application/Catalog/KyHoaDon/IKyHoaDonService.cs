using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.Application.Catalog.KyHoaDon
{
    public interface IKyHoaDonService
    {
        Task<List<sCTNSolution.Data.Entities.KyXuatHoaDon>> GetAll();
    }
}
