using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UYO_Final.Models
{
    public class Email
    {
        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }

        //public string To { get; set; }
        //public string From { get; set; }
        //public string Subject { get; set; }
        //public string Body { get; set; }
    }
}
