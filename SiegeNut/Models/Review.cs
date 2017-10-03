using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SiegeNut.Models
{
    public class Review
    {
        [Required, Key]
        public int ID { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public double Rating { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateWritten { get; set; }
        public string MainText { get; set; }

        public string AuthorID { get; set; }
        [ForeignKey("AuthorID")]
        public ApplicationUser Author { get; set; }
    }
}