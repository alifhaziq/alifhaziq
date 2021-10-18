using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Domains.PostgresDomains
{
    public class BaseClass
    {
        public BaseClass()
        {
            this.CreatedAt = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
