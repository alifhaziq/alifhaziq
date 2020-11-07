using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace totAPI.Models.Dtos
{
    public class CreateDepartmentDto
    {
        [Required]
        public string Name { get; set; }
    }
}
