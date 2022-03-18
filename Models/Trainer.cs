using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NikiTheofilaktidou_assignment_2.Models
{
    public class Trainer
    {
        [Display(Name = "TrainerId")]
        public int TrainerId { get; set; }
        [MinLength(2, ErrorMessage = "First name can't be shorter than 2 characters")]
        [MaxLength(20, ErrorMessage = "First name can't be longer than 20 characters")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [MinLength(2, ErrorMessage = "Last name can't be shorter than 2 characters")]
        [MaxLength(40, ErrorMessage = "Last name can't be longer than 40 characters")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        [MinLength(2, ErrorMessage = "Subject can't be shorter than 2 characters")]
        [MaxLength(20, ErrorMessage = "Subject can't be longer than 20 characters")]
        public string Subject { get; set; }
    }
}