using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment01.Models
{
    internal class Category
    {
        [Key]

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
