using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Contacting
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [MinLength(11,ErrorMessage ="sorry invalid phone number")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

       public string Message { get; set; }
    }
}
