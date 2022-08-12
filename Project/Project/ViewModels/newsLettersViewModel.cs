using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class newsLettersViewModel
    {
        public int id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Send_data { get; set; }
    }
}
