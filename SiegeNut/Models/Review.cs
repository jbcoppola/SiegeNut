using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiegeNut.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int Stars { get; set; }
        public string Title { get; set; }
        public DateTime DateWritten { get; set; }
        public string MainText { get; set; }
    }
}