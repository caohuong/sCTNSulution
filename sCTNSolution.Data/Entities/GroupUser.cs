using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class GroupUser
    {
        public int RowId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public int GroupGrant { get; set; }
        public string Description { get; set; }
    }
}
