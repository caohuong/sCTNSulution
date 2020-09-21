using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class Login
    {
        public int RowId { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string UserId { get; set; }
        public string GroupUser { get; set; }
        public int? IsUsed { get; set; }
    }
}
