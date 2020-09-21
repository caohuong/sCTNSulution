
using sCTNSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sCTNSolution.ViewModels.Common;
using sCTNSolution.ViewModels.Catalog.Hoadon;
using sCTNSolution.Utilities.Exceptions;

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
            if (repuest.KyHoadon != null)
            {
                var query = await (from h in _context.HoaDon
                                   join k in _context.KhachHang on h.MaKh equals k.MaKh
                                   join x in _context.XaPhuong on k.XaPhuong equals x.MaXaPhuong
                                   join kt in _context.KyXuatHoaDon on h.KyTinh equals kt.MaKyTinh
                                   where h.TongTien > 0 && h.KyTinh.Value.Year == repuest.KyHoadon.Year && h.KyTinh.Value.Month == repuest.KyHoadon.Month && h.KyTinh.Value.Day == repuest.KyHoadon.Day
                                   select new HoaDonViewModel
                                   {
                                       RowId = h.RowId,
                                       MaHoaDon = h.MaHoaDon,
                                       KyTinh = h.KyTinh,
                                       MaKh = h.MaKh,
                                       TenKh = h.TenKh,
                                       ChiSoCu = h.ChiSoCu,
                                       ChiSoMoi = h.ChiSoMoi,
                                       SoM3 = h.SoM3,
                                       DonGiaTdm = h.DonGiaTdm,
                                       TienTdm = h.TienTdm,
                                       DonGiaVdm = h.DonGiaVdm,
                                       //TienVdm = h.TienVdm,
                                       //TienBaoTri = h.TienBaoTri,
                                       //TienThueBao = h.TienThueBao,
                                       Vat = h.Vat,
                                       ThanhTien = h.ThanhTien,
                                       NoKyTruoc = h.NoKyTruoc,
                                       TongTien = h.TongTien,
                                       //NgayLap = h.NgayLap,
                                       //NgayThu = h.NgayThu,
                                       //DaThanhToan = h.DaThanhToan,
                                       //NhanVienGhiNuoc =h.NhanVienGhiNuoc,
                                       //NhanVienThuTien = h.NhanVienThuTien,
                                       GhiChu = k.MaTram,
                                       //NguoiTao = h.NguoiTao,
                                       //NgayTao = h.NgayTao,
                                       //NguoiThayDoi = h.NguoiThayDoi,
                                       //NgayThayDoi = h.NgayThayDoi,
                                       //NguyenNhan = h.NguyenNhan,
                                       PhiNuocThai = h.PhiNuocThai,
                                       Dm10 = h.Dm10,
                                       Dm20 = h.Dm20,
                                       Dm30 = h.Dm30,
                                       Dm40 = h.Dm40,
                                       PhanLoaiNuocSd = h.PhanLoaiNuocSd,
                                       Don_Gia_DM10 = 0.0,
                                       Don_Gia_DM20 = 0.0,
                                       Don_Gia_DM30 = 0.0,
                                       Don_Gia_DM40 = 0.0,

                                       PhanTramPhiSH = 0.0,
                                       MSThue = k.MstKh,
                                       So_Nha = k.SoNha,
                                       To_KH = k.ToKh,
                                       Ap_KH = k.ApKh,
                                       Xa_Phuong = x.TenXaPhuong,
                                       Ky_Tinh_TuNgay = kt.DenNgay,
                                       Ky_Tinh_DenNgay = kt.TuNgay,
                                   }).Take(2).ToListAsync();
                var totalcount = query.Count();
                var result = new PagedHoaDonByKyResult<HoaDonViewModel>()
                {
                    Items = query,
                    TotalRecord = totalcount,
                    KyHoaDon = repuest.KyHoadon
                };
                return result;
            }
            else
            {
                return null;
            }
        }

        public async Task<PagedHoaDonByKyResult<HoaDonViewModel>> GetAll()
        {
            var kylast =_context.KyXuatHoaDon.AsEnumerable().LastOrDefault();
            var query = await (from h in _context.HoaDon
                        join k in _context.KhachHang on h.MaKh equals k.MaKh
                        join x in _context.XaPhuong on k.XaPhuong equals x.MaXaPhuong
                        join kt in _context.KyXuatHoaDon on h.KyTinh equals kt.MaKyTinh
                        where h.TongTien > 0 && h.KyTinh.Value.Year == kylast.MaKyTinh.Year && h.KyTinh.Value.Month == kylast.MaKyTinh.Month && h.KyTinh.Value.Day == kylast.MaKyTinh.Day
                        select new HoaDonViewModel {
                            RowId = h.RowId,
                            MaHoaDon = h.MaHoaDon,
                            KyTinh = h.KyTinh,
                            MaKh = h.MaKh,
                            TenKh = h.TenKh,
                            ChiSoCu = h.ChiSoCu,
                            ChiSoMoi = h.ChiSoMoi,
                            SoM3 = h.SoM3,
                            DonGiaTdm = h.DonGiaTdm,
                            TienTdm = h.TienTdm,
                            DonGiaVdm = h.DonGiaVdm,
                            //TienVdm = h.TienVdm,
                            //TienBaoTri = h.TienBaoTri,
                            //TienThueBao = h.TienThueBao,
                            Vat = h.Vat,
                            ThanhTien = h.ThanhTien,
                            NoKyTruoc = h.NoKyTruoc,
                            TongTien = h.TongTien,
                            //NgayLap = h.NgayLap,
                            //NgayThu = h.NgayThu,
                            //DaThanhToan = h.DaThanhToan,
                            //NhanVienGhiNuoc =h.NhanVienGhiNuoc,
                            //NhanVienThuTien = h.NhanVienThuTien,
                            GhiChu = k.MaTram,
                            //NguoiTao = h.NguoiTao,
                            //NgayTao = h.NgayTao,
                            //NguoiThayDoi = h.NguoiThayDoi,
                            //NgayThayDoi = h.NgayThayDoi,
                            //NguyenNhan = h.NguyenNhan,
                            PhiNuocThai = h.PhiNuocThai,
                            Dm10 = h.Dm10,
                            Dm20 = h.Dm20,
                            Dm30 = h.Dm30,
                            Dm40 = h.Dm40,
                            PhanLoaiNuocSd = h.PhanLoaiNuocSd,
                            Don_Gia_DM10 = 0.0,
                            Don_Gia_DM20 = 0.0,
                            Don_Gia_DM30 = 0.0,
                            Don_Gia_DM40 = 0.0,

                            PhanTramPhiSH = 0.0,
                            MSThue = k.MstKh,
                            So_Nha = k.SoNha,
                            To_KH = k.ToKh,
                            Ap_KH = k.ApKh,
                            Xa_Phuong = x.TenXaPhuong,
                            Ky_Tinh_TuNgay = kt.DenNgay,
                            Ky_Tinh_DenNgay =kt.TuNgay,
                        }).Take(2).ToListAsync();
            //var data = await query.Select(sql => new HoaDonViewModel
            //{
            //    RowId = sql.h.RowId,
            //    MaHoaDon = sql.h.MaHoaDon,
            //    KyTinh = sql.h.KyTinh,
            //    MaKh = sql.h.MaKh,
            //    TenKh = sql.h.TenKh,
            //    ChiSoCu = sql.h.ChiSoCu,
            //    ChiSoMoi = sql.h.ChiSoMoi,
            //    SoM3 = sql.h.SoM3,
            //    DonGiaTdm = sql.h.DonGiaTdm,
            //    TienTdm = sql.h.TienTdm,
            //    DonGiaVdm = sql.h.DonGiaVdm,
            //    TienVdm = sql.h.TienVdm,
            //    TienBaoTri = sql.h.TienBaoTri,
            //    TienThueBao = sql.h.TienThueBao,
            //    Vat = sql.h.Vat,
            //    ThanhTien = sql.h.ThanhTien,
            //    NoKyTruoc = sql.h.NoKyTruoc,
            //    TongTien = sql.h.TongTien,
            //    NgayLap = sql.h.NgayLap,
            //    NgayThu = sql.h.NgayThu,
            //    DaThanhToan = sql.h.DaThanhToan,
            //    NhanVienGhiNuoc = sql.h.NhanVienGhiNuoc,
            //    NhanVienThuTien = sql.h.NhanVienThuTien,
            //    GhiChu = sql.h.GhiChu,
            //    NguoiTao = sql.h.NguoiTao,
            //    NgayTao = sql.h.NgayTao,
            //    NguoiThayDoi = sql.h.NguoiThayDoi,
            //    NgayThayDoi = sql.h.NgayThayDoi,
            //    NguyenNhan = sql.h.NguyenNhan,
            //    PhiNuocThai = sql.h.PhiNuocThai,
            //    Dm10 = sql.h.Dm10,
            //    Dm20 = sql.h.Dm20,
            //    Dm30 = sql.h.Dm30,
            //    Dm40 = sql.h.Dm40,
            //    PhanLoaiNuocSd = sql.h.PhanLoaiNuocSd,
            //    Don_Gia_DM10 = 0.0,
            //    Don_Gia_DM20 = 0.0,
            //    Don_Gia_DM30 = 0.0,
            //    Don_Gia_DM40 = 0.0,

            //    PhanTramPhiSH = 0.0,
            //    MSThue = sql.k.MstKh,
            //    So_Nha = sql.k.SoNha,
            //    To_KH = sql.k.ToKh,
            //    Ap_KH = sql.k.ApKh,
            //    Xa_Phuong = sql.x.TenXaPhuong,
            //    Ky_Tinh_TuNgay = sql.kt.DenNgay,
            //    Ky_Tinh_DenNgay = sql.kt.TuNgay,
            //}).ToListAsync();
            var totalcount = query.Count();
            var result = new PagedHoaDonByKyResult<HoaDonViewModel>()
            {
                Items = query,
                TotalRecord = totalcount
            };
            return result;
            // throw new sCTNSolutionException("asa");
        }

        public async Task<PagedHoaDonByKyResult<HoaDonViewModel>> GetAllByTram(GetHoaDonPagingRepuest repuest)
        {
            var query = await( from h in _context.HoaDon
                        join k in _context.KhachHang on h.MaKh equals k.MaKh
                        join x in _context.XaPhuong on k.XaPhuong equals x.MaXaPhuong
                        join kt in _context.KyXuatHoaDon on h.KyTinh equals kt.MaKyTinh
                        where h.TongTien > 0 && h.KyTinh.Value.Year == repuest.KyHoadon.Year && h.KyTinh.Value.Month == repuest.KyHoadon.Month && h.KyTinh.Value.Day == repuest.KyHoadon.Day && k.MaTram == repuest.MaTram 
                        select new HoaDonViewModel
                        {
                            RowId = h.RowId,
                            MaHoaDon = h.MaHoaDon,
                            KyTinh = h.KyTinh,
                            MaKh = h.MaKh,
                            TenKh = h.TenKh,
                            ChiSoCu = h.ChiSoCu,
                            ChiSoMoi = h.ChiSoMoi,
                            SoM3 = h.SoM3,
                            DonGiaTdm = h.DonGiaTdm,
                            TienTdm = h.TienTdm,
                            DonGiaVdm = h.DonGiaVdm,
                            //TienVdm = h.TienVdm,
                            //TienBaoTri = h.TienBaoTri,
                            //TienThueBao = h.TienThueBao,
                            Vat = h.Vat,
                            ThanhTien = h.ThanhTien,
                            NoKyTruoc = h.NoKyTruoc,
                            TongTien = h.TongTien,
                            //NgayLap = h.NgayLap,
                            //NgayThu = h.NgayThu,
                            //DaThanhToan = h.DaThanhToan,
                            //NhanVienGhiNuoc =h.NhanVienGhiNuoc,
                            //NhanVienThuTien = h.NhanVienThuTien,
                            GhiChu = k.MaTram,
                            //NguoiTao = h.NguoiTao,
                            //NgayTao = h.NgayTao,
                            //NguoiThayDoi = h.NguoiThayDoi,
                            //NgayThayDoi = h.NgayThayDoi,
                            //NguyenNhan = h.NguyenNhan,
                            PhiNuocThai = h.PhiNuocThai,
                            Dm10 = h.Dm10,
                            Dm20 = h.Dm20,
                            Dm30 = h.Dm30,
                            Dm40 = h.Dm40,
                            PhanLoaiNuocSd = h.PhanLoaiNuocSd,
                            Don_Gia_DM10 = 0.0,
                            Don_Gia_DM20 = 0.0,
                            Don_Gia_DM30 = 0.0,
                            Don_Gia_DM40 = 0.0,

                            PhanTramPhiSH = 0.0,
                            MSThue = k.MstKh,
                            So_Nha = k.SoNha,
                            To_KH = k.ToKh,
                            Ap_KH = k.ApKh,
                            Xa_Phuong = x.TenXaPhuong,
                            Ky_Tinh_TuNgay = kt.DenNgay,
                            Ky_Tinh_DenNgay = kt.TuNgay,
                        }).Take(3).ToListAsync();
            var totalcount = query.Count();
            var result = new PagedHoaDonByKyResult<HoaDonViewModel>()
            {
                Items = query,
                TotalRecord = totalcount,
                KyHoaDon = repuest.KyHoadon
            };
            return result;
        }
    }
}
