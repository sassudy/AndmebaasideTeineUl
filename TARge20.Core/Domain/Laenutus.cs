using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Laenutus
    {
        public Guid Id { get; set; }
        public string ItemLoaned { get; set; }
       // public Ametinimetus Ametinimetus { get; set; }
        public Employee Employee { get; set; }
        public string Kommentaar { get; set; }

    }
}
