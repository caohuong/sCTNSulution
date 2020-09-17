using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class BangGiaNuoc
    {
        public BangGiaNuoc()
        {
            BangGiaNuocTheoTram = new HashSet<BangGiaNuocTheoTram>();
            HopDongSuDung = new HashSet<HopDongSuDung>();
        }

        public int RowId { get; set; }
        public string MaBangGia { get; set; }
        public string Ten { get; set; }
        public double? GiaCoDinh { get; set; }
        public string GhiChu { get; set; }
        public int? NguonNuoc { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public virtual ICollection<BangGiaNuocTheoTram> BangGiaNuocTheoTram { get; set; }
        public virtual ICollection<HopDongSuDung> HopDongSuDung { get; set; }
    }
}
