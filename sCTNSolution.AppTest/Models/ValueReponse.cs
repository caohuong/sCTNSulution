using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Models
{
    public class ValueReponse<T>
    {
        public int codes { get; set; }
        public bool state { get; set; }
        public string msge { get; set; }
        public List<T> data { get; set; }
    }
}
