﻿using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class GroupFunction
    {
        public int RowId { get; set; }
        public string GroupName { get; set; }
        public string FormName { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public string Menu1 { get; set; }
        public string Menu2 { get; set; }
        public int? IsReadOnly { get; set; }
        public string SecurityButton { get; set; }
    }
}
