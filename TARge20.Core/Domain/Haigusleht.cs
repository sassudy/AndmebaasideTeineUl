using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Haigusleht
    {
        public Guid Id { get; set; }
        public DateTime Alguskuupaev { get; set; }
        public DateTime Loppkuupaev { get; set; }
        public string Kommentaar { get; set; }
        public Employee Employee { get; set; }
    }
}
