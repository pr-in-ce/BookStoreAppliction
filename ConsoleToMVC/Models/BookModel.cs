using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Models
{
    public class BookModel
    {
        public int Id { get; set; }
     
        [Required]
        [DataType(DataType.MultilineText)]
        public string Author { get; set; }

        [Required]
        public string Title{ get; set; }
        public int NoOfPages { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotalPages { get; set; }
    }
}
