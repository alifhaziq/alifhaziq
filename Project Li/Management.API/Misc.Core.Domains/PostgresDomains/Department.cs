using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Domains.PostgresDomains
{
    public class Department :BaseClass
    {
        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}
