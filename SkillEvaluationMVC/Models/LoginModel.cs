using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillEvaluationMVC.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Email can not be empty")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        public string Password { get; set; }
    }
}