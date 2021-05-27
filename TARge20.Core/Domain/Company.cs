using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public int RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ContactPerson { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Comment { get; set; }

        public AccessPermit AccessPermit { get; set; }
        public Harukontor Harukontor { get; set; }
        public Feedback Feedback { get; set; }
    }
}
