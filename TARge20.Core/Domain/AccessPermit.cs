
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermit
    {
        public Guid Id { get; set; }
        public string Permit { get; set; }
        public string Comment { get; set; }
        public Employee Employee { get; set; }
        //public Company Company { get; set; }

    }
}
