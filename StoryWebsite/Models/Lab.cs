using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcSkeleton.Models
{
    public class Lab
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Number")]
        public int number { get; set; }

        [Display(Name = "Topic")]
        public string topic { get; set; }

        [Display(Name = "Target")]
        public string target { get; set; }

        [Display(Name = "Due")]
        public DateTime due { get; set; }
    }


       
}
