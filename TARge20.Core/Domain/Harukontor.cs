using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
        public class Harukontor
    {
        public Guid Id { get; set; }
        public string Adress { get; set; }
        public Employee Employee { get; set; }
        public string ContactPerson { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Comment { get; set; }
        //public Company Company { get; set; }

    }
}
