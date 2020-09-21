using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class ChiSoTramNuoc
    {
        public int RowId { get; set; }
        public string MaTram { get; set; }
        public DateTime ThangNam { get; set; }
        public int? TongSoHo { get; set; }
        public int? SoHoHoatDong { get; set; }
        public int? LuongTieuThu { get; set; }
        public double? TyLeSuDungNuoc { get; set; }
        public int? ThatThoat { get; set; }
        public int? ChenhLech { get; set; }
        public double? TyLeTtNuoc { get; set; }
        public int? DhtKyNay { get; set; }
        public int? DhdKyNay { get; set; }
        public int? DhtSuDung { get; set; }
        public int? DhdSuDung { get; set; }
        public int? DhtKyTruoc { get; set; }
        public int? DhdKyTruoc { get; set; }
        public double? TyLeDienKhaiThac { get; set; }
        public double? TyLeDienTieuThu { get; set; }
        public double? LuongNuocSxBqHo { get; set; }
        public double? LuongNuocTtBqHo { get; set; }
        public double? Dau { get; set; }
        public double? Nhot { get; set; }
        public double? Clorine { get; set; }
        public double? Phen { get; set; }
        public int? ChiPhiVanHanh { get; set; }
        public int? DinhMuc { get; set; }
        public int? TienDien { get; set; }
        public int? ThatThoatDuoi22 { get; set; }
        public int? VanPhongPham { get; set; }
        public int? CongTacPhi { get; set; }
        public int? SoHoaDon { get; set; }
        public int? ChiPhiKhac { get; set; }
        public int? TongChiPhi { get; set; }
        public int? Luong { get; set; }
        public int? Phat { get; set; }
        public int? ConLaiDuocLinh { get; set; }
        public int? DienThoai { get; set; }
        public int? SuaChua { get; set; }
        public int? ChiPhiMoiM3Nuoc { get; set; }
        public int? SoGioLamViec { get; set; }
        public double? PhanNan { get; set; }
        public int? DoanhThuKyTruoc { get; set; }
        public int? DoanhThuKyNay { get; set; }
        public int? NoKyTruoc { get; set; }
        public int? Xang { get; set; }
        public int? SoTienDaNop { get; set; }
        public double? GiaNuocBanRaBqChiPhi { get; set; }
        public int? Price { get; set; }
        public int? NopDu { get; set; }
        public int? ThucTe { get; set; }
        public int? NoCaNhan { get; set; }
        public int? NoKhachHang { get; set; }
        public bool? TinhTrang { get; set; }
        public int? NoCu { get; set; }
        public int? TongNo { get; set; }
        public string GhiChu { get; set; }

        public virtual TramNuoc MaTramNavigation { get; set; }
    }
}
