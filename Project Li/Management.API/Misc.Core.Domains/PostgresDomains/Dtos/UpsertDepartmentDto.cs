﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Domains.PostgresDomains.Dtos
{
    public class UpsertDepartmentDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ShortName { get; set; }
    }
}
