using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title{ get; set; }
        public int NoOfPages { get; set; }
    }
}
