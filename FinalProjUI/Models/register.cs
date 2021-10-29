using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace FinalProjUI.Models
{
    public class register 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }
        public string Password { get; set; }
    }
}
