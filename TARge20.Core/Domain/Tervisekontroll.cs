using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Tervisekontroll
    {
        public Guid Id { get; set; }
        public DateTime Kuupaev { get; set; }
        public string Kommentaar { get; set; }
        public Employee Employee { get; set; }

    }
}
