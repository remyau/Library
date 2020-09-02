using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }       
        public DateTime Date_Published { get; set; }
        public DateTime Date_Added { get; set; }

        public int MyProperty { get; set; }
        public String Category { get; set; }
    }
}