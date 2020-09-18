using sCTNSolution.Application.Catalog.Hoadon.Dtos;
using sCTNSolution.Application.Dtos;
using sCTNSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace sCTNSolution.Application.Catalog.Hoadon
{
    public class ManagerHoaDonService : IManagerHoaDonService
    {
        private CTNKGContext _context;
       public ManagerHoaDonService(CTNKGContext context)
        {
            _context = context;
        }

        public async  Task<PagedHoaDonByKyResult<HoaDonViewModel>> GetAll(PagingRequestBase repuest)
        {
            var query = from h in _context.HoaDon
                        join k in _context.KhachHang on h.MaKh equals k.MaKh
                        join x in _context.XaPhuong on k.XaPhuong equals x.MaXaPhuong
                        join kt in _context.KyXuatHoaDon on h.KyTinh equals kt.MaKyTinh
                        where h.KyTinh.Value.Year == repuest.KyHoadon.Year && h.KyTinh.Value.Month == repuest.KyHoadon.Month && h.KyTinh.Value.Day == repuest.KyHoadon.Day
                        select new {h,k,x,kt };
            var data = await query.Select(sql => new HoaDonViewModel
            {
                RowId = sql.h.RowId,
                MaHoaDon = sql.h.MaHoaDon,
                KyTinh = sql.h.KyTinh,
                MaKh = sql.h.MaKh,
                TenKh = sql.h.TenKh,
                ChiSoCu = sql.h.ChiSoCu,
                ChiSoMoi = sql.h.ChiSoMoi,
                SoM3 = sql.h.SoM3,
                DonGiaTdm = sql.h.DonGiaTdm,
                TienTdm = sql.h.TienTdm,
                DonGiaVdm = sql.h.DonGiaVdm,
                TienVdm = sql.h.TienVdm,
                TienBaoTri = sql.h.TienBaoTri,
                TienThueBao = sql.h.TienThueBao,
                Vat = sql.h.Vat,
                ThanhTien = sql.h.ThanhTien,
                NoKyTruoc = sql.h.NoKyTruoc,
                TongTien = sql.h.TongTien,
                NgayLap = sql.h.NgayLap,
                NgayThu = sql.h.NgayThu,
                DaThanhToan = sql.h.DaThanhToan,
                NhanVienGhiNuoc = sql.h.NhanVienGhiNuoc,
                NhanVienThuTien = sql.h.NhanVienThuTien,
                GhiChu = sql.h.GhiChu,
                NguoiTao = sql.h.NguoiTao,
                NgayTao = sql.h.NgayTao,
                NguoiThayDoi = sql.h.NguoiThayDoi,
                NgayThayDoi = sql.h.NgayThayDoi,
                NguyenNhan = sql.h.NguyenNhan,
                PhiNuocThai = sql.h.PhiNuocThai,
                Dm10 = sql.h.Dm10,
                Dm20 = sql.h.Dm20,
                Dm30 = sql.h.Dm30,
                Dm40 = sql.h.Dm40,
                PhanLoaiNuocSd = sql.h.PhanLoaiNuocSd,
                Don_Gia_DM10 = 0.0,
                Don_Gia_DM20 = 0.0,
                Don_Gia_DM30 = 0.0,
                Don_Gia_DM40 = 0.0,
              
                PhanTramPhiSH = 0.0,
                MSThue = sql.k.MstKh,
                So_Nha = sql.k.SoNha,
                To_KH = sql.k.ToKh,
                Ap_KH = sql.k.ApKh,
                Xa_Phuong = sql.x.TenXaPhuong,
                Ky_Tinh_TuNgay = sql.kt.DenNgay,
                Ky_Tinh_DenNgay = sql.kt.TuNgay,
            }).ToListAsync();
            var totalcount = await query.CountAsync();
            var result = new PagedHoaDonByKyResult<HoaDonViewModel>()
            {
                Items = data,
                TotalRecord =totalcount
            };
            return result;
        }

        public async Task<PagedHoaDonByKyResult<HoaDonViewModel>> GetAllByTram(GetHoaDonPagingRepuest repuest)
        {
            var query = from h in _context.HoaDon
                        join k in _context.KhachHang on h.MaKh equals k.MaKh
                        join x in _context.XaPhuong on k.XaPhuong equals x.MaXaPhuong
                        join kt in _context.KyXuatHoaDon on h.KyTinh equals kt.MaKyTinh
                        where h.KyTinh.Value.Year == repuest.KyHoadon.Year && h.KyTinh.Value.Month == repuest.KyHoadon.Month && h.KyTinh.Value.Day == repuest.KyHoadon.Day && k.MaTram == repuest.MaTram 
                        select new { h, k, x, kt };
            var data = await query.Select(sql => new HoaDonViewModel
            {
                RowId = sql.h.RowId,
                MaHoaDon = sql.h.MaHoaDon,
                KyTinh = sql.h.KyTinh,
                MaKh = sql.h.MaKh,
                TenKh = sql.h.TenKh,
                ChiSoCu = sql.h.ChiSoCu,
                ChiSoMoi = sql.h.ChiSoMoi,
                SoM3 = sql.h.SoM3,
                DonGiaTdm = sql.h.DonGiaTdm,
                TienTdm = sql.h.TienTdm,
                DonGiaVdm = sql.h.DonGiaVdm,
                TienVdm = sql.h.TienVdm,
                TienBaoTri = sql.h.TienBaoTri,
                TienThueBao = sql.h.TienThueBao,
                Vat = sql.h.Vat,
                ThanhTien = sql.h.ThanhTien,
                NoKyTruoc = sql.h.NoKyTruoc,
                TongTien = sql.h.TongTien,
                NgayLap = sql.h.NgayLap,
                NgayThu = sql.h.NgayThu,
                DaThanhToan = sql.h.DaThanhToan,
                NhanVienGhiNuoc = sql.h.NhanVienGhiNuoc,
                NhanVienThuTien = sql.h.NhanVienThuTien,
                GhiChu = sql.h.GhiChu,
                NguoiTao = sql.h.NguoiTao,
                NgayTao = sql.h.NgayTao,
                NguoiThayDoi = sql.h.NguoiThayDoi,
                NgayThayDoi = sql.h.NgayThayDoi,
                NguyenNhan = sql.h.NguyenNhan,
                PhiNuocThai = sql.h.PhiNuocThai,
                Dm10 = sql.h.Dm10,
                Dm20 = sql.h.Dm20,
                Dm30 = sql.h.Dm30,
                Dm40 = sql.h.Dm40,
                PhanLoaiNuocSd = sql.h.PhanLoaiNuocSd,
                Don_Gia_DM10 = 0.0,
                Don_Gia_DM20 = 0.0,
                Don_Gia_DM30 = 0.0,
                Don_Gia_DM40 = 0.0,

                PhanTramPhiSH = 0.0,
                MSThue = sql.k.MstKh,
                So_Nha = sql.k.SoNha,
                To_KH = sql.k.ToKh,
                Ap_KH = sql.k.ApKh,
                Xa_Phuong = sql.x.TenXaPhuong,
                Ky_Tinh_TuNgay = sql.kt.DenNgay,
                Ky_Tinh_DenNgay = sql.kt.TuNgay,
            }).ToListAsync();
            var totalcount = await query.CountAsync();
            var result = new PagedHoaDonByKyResult<HoaDonViewModel>()
            {
                Items = data,
                TotalRecord = totalcount
            };
            return result;
        }
    }
}
