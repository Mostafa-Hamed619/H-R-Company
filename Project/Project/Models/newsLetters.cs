using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class newsLetters
    {
        public int id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        public string send { get; set; }
    }
}
