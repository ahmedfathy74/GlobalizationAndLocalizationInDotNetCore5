using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizationAndLocalizationInDotNetCore5.Models
{
    public class CreateTestViewModel
    {
        [Display(Name = "Name"), Required(ErrorMessage = "Required")]
        public string Name { get; set; }
    }
}
