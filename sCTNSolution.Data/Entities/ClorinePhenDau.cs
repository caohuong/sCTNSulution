using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class ClorinePhenDau
    {
        public int RowId { get; set; }
        public string MaCpd { get; set; }
        public string MaTram { get; set; }
        public double? Clorine { get; set; }
        public double? Phen { get; set; }
        public double? Dau { get; set; }
        public string GhiChu { get; set; }

        public virtual TramNuoc MaTramNavigation { get; set; }
    }
}
