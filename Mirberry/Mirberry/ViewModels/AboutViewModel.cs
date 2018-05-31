using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mirberry.ViewModels
{
    public class AboutViewModel
    {
        [Required]
        [MaxLength(200, ErrorMessage ="Message too long")]
        public string message { get; set; }
        [EmailAddress]
        public string email { get; set; }
    }
}
