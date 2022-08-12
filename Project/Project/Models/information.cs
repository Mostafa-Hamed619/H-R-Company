using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class information
    {
        public int id { get; set; }
        public string  Country{ get; set; }

        public string City { get; set; }

        [StringLength(11,ErrorMessage ="sorry invalid Number")]
        public string Phone { get; set; }

        [EmailAddress]
        public string EmaiAddress { get; set; }

        public string Street { get; set; }
    }
}
