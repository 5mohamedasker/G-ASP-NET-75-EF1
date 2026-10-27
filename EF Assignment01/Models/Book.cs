using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment01.Models
{
    internal class Book
    {
        public string Title { get; set; }
        [Key]
        public string ISBNNumber { get; set; }
        public decimal Price { get; set; }
        public string NumberOfPages { get; set; }
        public DateOnly PublishedYear { get; set; }
        public bool IsInStock { get; set; }
    }
}
