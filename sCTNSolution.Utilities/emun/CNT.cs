using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace sCTNSolution.Utilities.emun
{
    public class CNT
    {
        public static string Num2Text(string s, bool Local = false)
        {
            char DS = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char GS = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator);
            bool fDS = false;
            bool fDecAdd2 = false;
            string[] so = new string[10]
            {
            "không",
            "một",
            "hai",
            "ba",
            "bốn",
            "năm",
            "sáu",
            "bảy",
            "tám",
            "chín"
            };
            string[] hang = new string[4]
            {
            "",
            "ngàn",
            "triệu",
            "tỷ"
            };
            if (Local)
            {
                hang[1] = "nghìn";
            }
            string str3 = "";
            s = s.Replace(Conversions.ToString(GS), "");
            checked
            {
                if (Operators.CompareString(s.Substring(s.Length - 1, 1), Conversions.ToString(DS), false) == 0)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                int n = s.Length;
                while (Operators.CompareString(s.Substring(0, 1), "0", false) == 0)
                {
                    s = s.Substring(1, s.Length - 1);
                }
                if (Operators.CompareString(s.Substring(0, 1), Conversions.ToString(DS), false) == 0)
                {
                    s = "0" + s;
                }
                int cntDS = 0;
                if (Strings.InStr(s, Conversions.ToString(DS)) != 0)
                {
                    int num = s.Length - 1;
                    n = 0;
                    while (true)
                    {
                        int num2 = n;
                        int num3 = num;
                        if (num2 > num3)
                        {
                            break;
                        }
                        if (Operators.CompareString(s.Substring(n, 1), Conversions.ToString(DS), false) == 0)
                        {
                            cntDS++;
                        }
                        n++;
                    }
                }
                if (cntDS > 1)
                {
                    return "";
                }
                if (cntDS > 0)
                {
                    while (Operators.CompareString(s.Substring(s.Length - 1, 1), "0", false) == 0)
                    {
                        s = s.Substring(0, s.Length - 1);
                    }
                }
                if (Operators.CompareString(s.Substring(s.Length - 1, 1), Conversions.ToString(DS), false) == 0)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                n = s.Length - 1;
                if (n == 0)
                {
                    str3 = "";
                }
                else
                {
                    int k = 0;
                    while (n >= 0)
                    {
                        if (Operators.CompareString(s.Substring(n, 1), Conversions.ToString(DS), false) == 0)
                        {
                            fDS = true;
                            n--;
                            goto IL_056f;
                        }
                        int donvi = Conversions.ToInteger(Conversion.Int(s.Substring(n, 1)));
                        n--;
                        goto IL_02f8;
                    IL_0352:
                        n--;
                        int tram;
                        if (n > -1)
                        {
                            if (Operators.CompareString(s.Substring(n, 1), Conversions.ToString(DS), false) == 0)
                            {
                                n--;
                                tram = -1;
                                fDS = true;
                                goto IL_03b7;
                            }
                            tram = Conversions.ToInteger(Conversion.Int(s.Substring(n, 1)));
                        }
                        else
                        {
                            tram = -1;
                        }
                        goto IL_03af;
                    IL_0335:
                        goto IL_0352;
                    IL_02db:
                        goto IL_02f8;
                    IL_02f8:
                        int chuc;
                        if (n > -1)
                        {
                            if (Operators.CompareString(s.Substring(n, 1), Conversions.ToString(DS), false) == 0)
                            {
                                n--;
                                chuc = -1;
                                tram = -1;
                                fDS = true;
                                goto IL_03b7;
                            }
                            chuc = Conversions.ToInteger(Conversion.Int(s.Substring(n, 1)));
                        }
                        else
                        {
                            chuc = -1;
                        }
                        goto IL_0352;
                    IL_0390:
                        goto IL_03af;
                    IL_03af:
                        n--;
                        goto IL_03b7;
                    IL_03b7:
                        if ((donvi > 0) | (chuc > 0) | (tram > 0) | (k == 3))
                        {
                            str3 = hang[k] + " " + str3;
                        }
                        k++;
                        if (k > 3)
                        {
                            k = 1;
                        }
                        if (donvi == 1 && chuc > 1)
                        {
                            str3 = "mốt " + str3;
                        }
                        else if (donvi == 4 && chuc > 1)
                        {
                            str3 = ((!Local) ? (so[donvi] + " " + str3) : ("tư " + str3));
                        }
                        else
                        {
                            switch (donvi)
                            {
                                case 5:
                                    str3 = ((chuc <= 0) ? (so[donvi] + " " + str3) : ("lăm " + str3));
                                    break;
                                default:
                                    str3 = so[donvi] + " " + str3;
                                    break;
                                case 0:
                                    break;
                            }
                        }
                        if (chuc < 0)
                        {
                            if (!fDS)
                            {
                                break;
                            }
                        }
                        else if (chuc == 0 && donvi > 0)
                        {
                            str3 = "lẻ " + str3;
                        }
                        else if (chuc == 1)
                        {
                            str3 = "mười " + str3;
                        }
                        else if (chuc > 1)
                        {
                            str3 = so[chuc] + " mươi " + str3;
                        }
                        if (tram < 0)
                        {
                            if (!fDS)
                            {
                                break;
                            }
                        }
                        else if ((tram > 0) | (chuc > 0) | (donvi > 0))
                        {
                            str3 = so[tram] + " trăm " + str3;
                        }
                        goto IL_056f;
                    IL_056f:
                        if (fDS)
                        {
                            str3 = "phảy " + str3;
                            k = 0;
                            fDS = false;
                            fDecAdd2 = true;
                        }
                    }
                }
                if (str3.Length > 0)
                {
                    str3 = str3.Trim();
                    str3 = str3.Replace("  ", " ");
                    return Strings.UCase(str3.Substring(0, 1)) + str3.Substring(1, str3.Length - 1);
                }
                return "";
            }
        IL_05fb:
            string Num2Text;
            return Num2Text;
        }
       
        public static string GetDiaChi(string sonha, string tokh, string apkh, string xaphuong)
        {
            string str = "";
            if (!string.IsNullOrEmpty(sonha)) { str += sonha; } else { str = ""; }
            if (!string.IsNullOrEmpty(sonha) && !string.IsNullOrEmpty(tokh)) { str += ", "; } else { str += ""; }
            if (!string.IsNullOrEmpty(tokh)) { str += $@"Tổ {tokh}"; } else { str += ""; }
            if ((!string.IsNullOrEmpty(tokh) && !string.IsNullOrEmpty(apkh)) || (!string.IsNullOrEmpty(sonha) && !string.IsNullOrEmpty(apkh))) { str += ", "; } else { str += ""; }
            if (!string.IsNullOrEmpty(apkh)) { str += $@"Ấp {apkh}"; } else { str += ""; }
            if (!string.IsNullOrEmpty(tokh) || !string.IsNullOrEmpty(apkh)) { str += $", {xaphuong}"; } else { str += ""; }
            return str;
        }
    }
}
