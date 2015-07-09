using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UIV.MVC.Models
{
    public class UserInputViewModel
    {
        [Required(ErrorMessage = "Nothing to Validate!")]
        [StringLength(12, ErrorMessage = "Length: From 5 to 12 alphanumeric characters", MinimumLength = 5)]
        public string InputStr { get; set; }

        public string Result { get; set; }

        public string ResultList { get; set; }

        public string Counter { get; set; }
    }
}