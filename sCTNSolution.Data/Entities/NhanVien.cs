using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            NhanVienVanHanhTram = new HashSet<NhanVienVanHanhTram>();
        }

        public int RowId { get; set; }
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string ChucVu { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<NhanVienVanHanhTram> NhanVienVanHanhTram { get; set; }
    }
}
