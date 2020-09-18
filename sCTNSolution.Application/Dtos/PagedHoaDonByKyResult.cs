﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sCTNSolution.Application.Dtos
{
    public class PagedHoaDonByKyResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
        public DateTime KyHoaDon { get; set; }
    }
}
