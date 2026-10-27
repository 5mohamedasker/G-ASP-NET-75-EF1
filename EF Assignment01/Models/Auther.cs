using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment01.Models
{
    internal class Auther
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        [Key]
        public string EmailAddress { get; set; }
        public string Biography { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
