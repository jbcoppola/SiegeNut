using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SiegeNut.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateWritten { get; set; }
        public string MainText { get; set; }
        public string Author { get; set; }
    }
}