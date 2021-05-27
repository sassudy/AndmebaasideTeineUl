using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string AnonomysHint { get; set; }
        public string Proposal { get; set; }
        public string Comment { get; set; }

}
}
