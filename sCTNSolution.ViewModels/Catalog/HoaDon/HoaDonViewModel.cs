using sCTNSolution.Utilities.emun;
using System;
using System.Collections.Generic;
using System.Text;
using sCTNSolution.Data.Entities;
namespace sCTNSolution.ViewModels.Catalog.Hoadon
{
    public class HoaDonViewModel: HoaDon
    {
       
     //   public Nullable<double> giamgia { get; set; }
        public Nullable<double> Don_Gia_DM10 { get; set; }
        public Nullable<double> Don_Gia_DM20 { get; set; }
        public Nullable<double> Don_Gia_DM30 { get; set; }
        public Nullable<double> Don_Gia_DM40 { get; set; }
        //public Nullable<System.DateTime> Ngayin { get; set; }
        //public string NgayInString { get; set; }
        //public string LanInString { get; set; }
        public double PhanTramPhiSH { get; set; }
        public string MSThue { get; set; }
        public string So_Nha { get; set; }
        public string To_KH { get; set; }
        public string Ap_KH { get; set; }
        public string Xa_Phuong { get; set; }
        public Nullable<System.DateTime> Ky_Tinh_TuNgay { get; set; }
        public Nullable<System.DateTime> Ky_Tinh_DenNgay { get; set; }

        public Nullable<double> TT_DM10 => Dm10 > 0 ? Math.Round((Convert.ToDouble(Dm10) * Don_Gia_DM10).Value, 0, MidpointRounding.AwayFromZero) : 0;
        public Nullable<double> TT_DM20 => Dm20 > 0 ? Math.Round((Convert.ToDouble(Dm20) * Don_Gia_DM20).Value, 0, MidpointRounding.AwayFromZero) : 0;
        public Nullable<double> TT_DM30 => Dm30 > 0 ? Math.Round((Convert.ToDouble(Dm30) * Don_Gia_DM30).Value, 0, MidpointRounding.AwayFromZero) : 0;
        public Nullable<double> TT_DM40 => Dm30 > 0 ? Math.Round((Convert.ToDouble(Dm40) * Don_Gia_DM40).Value, 0, MidpointRounding.AwayFromZero) : 0;
        public string BangChu => CNT.Num2Text(TongTien.ToString(), false) + @" đồng.";
        public int PhanTram5 => 5;
        public double PhanTram10 => PhanTramPhiSH * 100;
        public string DiaChi => CNT.GetDiaChi(So_Nha, To_KH, Ap_KH, Xa_Phuong);
        public string StringKy_Tinh => $"{KyTinh.Value.ToString("MM")}({Ky_Tinh_TuNgay.Value.ToString("dd/MM")}-{Ky_Tinh_DenNgay.Value.ToString("dd/MM")})";
    }
}
