using System;
using System.Collections.Generic;

namespace sCTNSolution.Data.Entities
{
    public partial class Company
    {
        public int RowId { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string TaxCode { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
    }
}
