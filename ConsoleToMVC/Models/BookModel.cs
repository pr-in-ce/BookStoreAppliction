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
        [StringLength(100,MinimumLength =5)]
        [Required(ErrorMessage = "Please enter the Title of your book")]
        public string Title { get; set; }
        [Required (ErrorMessage ="Please enter the Author name")]
        [DataType(DataType.MultilineText)]
        public string Author { get; set; }  
        public int NoOfPages { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        [Required (ErrorMessage = "Please enter the Total no of pages")]
        [Display(Name ="Total pages of book")]
        public int TotalPages { get; set; }
    }
}





