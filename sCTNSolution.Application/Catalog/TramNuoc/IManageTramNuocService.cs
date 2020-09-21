
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.Application.Catalog.TramNuoc
{
    public interface IManageTramNuocService
    {
        Task<List<sCTNSolution.Data.Entities.TramNuoc>> GetAll();
    }
}
