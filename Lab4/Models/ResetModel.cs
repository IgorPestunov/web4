using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class ResetModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Message { get; set; }
        public string Code { get; set; }
    }
}
