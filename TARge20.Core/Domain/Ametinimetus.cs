using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ametinimetus
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string Nimetus { get; set; }
        public string Kommentaar { get; set; }
        public Laenutus Laenutuses { get; set; }
    }
}
